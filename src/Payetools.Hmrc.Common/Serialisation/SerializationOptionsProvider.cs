// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Common.Rti;
using Payetools.Hmrc.Common.Rti.Model;
using Payetools.Payroll.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Payetools.Hmrc.Common.Serialisation;

/// <summary>
/// Provider of <see cref="JsonSerializerOptions"/> instances that enable type mapping from
/// interface types to concrete types.
/// </summary>
public class SerializationOptionsProvider
{
    private readonly List<(Type, Type)> _typeMappings = new List<(Type, Type)>();

    private static readonly JsonSerializerOptions _defaultSerialisationOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters =
        {
            new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
        }
    };

    /// <summary>
    /// Adds a mapping from the specified interface type to the specified concrete type.
    /// </summary>
    /// <param name="interfaceType">Interface type.</param>
    /// <param name="implementationType">Concrete implementation type.</param>
    /// <returns>The current <see cref="SerializationOptionsProvider"/> instance, so
    /// <see cref="AddTypeMapping(Type, Type)"/> calls can be chained (i.e., using fluent syntax).</returns>
    /// <exception cref="InvalidOperationException">Thrown if the concrete type does not
    /// implement the specified interface.</exception>
    public SerializationOptionsProvider AddTypeMapping(Type interfaceType, Type implementationType)
    {
        if (!interfaceType.IsAssignableFrom(implementationType))
            throw new InvalidOperationException("Implementation type is not assignable to interface type");

        _typeMappings.Add((interfaceType, implementationType));

        return this;
    }

    /// <summary>
    /// Gets a new <see cref="JsonSerializerOptions"/> instance that includes any interface to concrete
    /// class mappings added via the <see cref="AddTypeMapping(Type, Type)"/> method.
    /// </summary>
    /// <param name="initialOptions">Initial <see cref="JsonSerializerOptions"/> to copy from. Optional.</param>
    /// <returns>New <see cref="JsonSerializerOptions"/> instance that includes previously added type mappings.</returns>
    public JsonSerializerOptions GetOptions(JsonSerializerOptions? initialOptions = null)
    {
#if NET7_0_OR_GREATER

        var modifiers = new List<Action<JsonTypeInfo>>();

        _typeMappings.ForEach(types =>
            modifiers.Add(
                (typeInfo) =>
                    {
                        if (typeInfo.Type == types.Item1)
                            typeInfo.CreateObject = () => Activator.CreateInstance(types.Item2, nonPublic: true)!;
                    }));

        var typeInfoResolver = new DefaultJsonTypeInfoResolver();

        modifiers.ForEach(m => typeInfoResolver.Modifiers.Add(m));

        var options = initialOptions != null ?
            new JsonSerializerOptions(initialOptions) { TypeInfoResolver = typeInfoResolver } :
            new JsonSerializerOptions { TypeInfoResolver = typeInfoResolver };

        return options;
#else
        throw new NotSupportedException("Interface to concrete type resolution is not supported by System.Text.Json in .Net 6.0 and below");
#endif
    }

    /// <summary>
    /// Gets the <see cref="JsonSerializerOptions"/> for the target document type, adding type mappings
    /// from interfaces to concrete classes.
    /// </summary>
    /// <param name="documentType">RTI document type (FPS/EPS/NVR).</param>
    /// <param name="targetType">Type of the top-level document that implements the appropriate
    /// top-level interface.</param>
    /// <param name="options">Options <see cref="JsonSerializerOptions"/> instance to use for initialising
    /// the resulting options. If absent, then the default (web-style) options are used.</param>
    /// <returns><see cref="JsonSerializerOptions"/> instance suitably initialised.</returns>
    public static JsonSerializerOptions GetRtiDocumentSerialisationOptions(
        RtiDocumentType documentType,
        Type targetType,
        JsonSerializerOptions? options = null)
    {
        var baseOptions = options ?? _defaultSerialisationOptions;

        var provider = new SerializationOptionsProvider();

        provider
            .AddTypeMapping(typeof(ISubmissionHeader), typeof(SubmissionHeader))
            .AddTypeMapping(typeof(IRtiSubmissionResponseOptions), typeof(RtiSubmissionResponseOptions))
            .AddTypeMapping(typeof(IRtiCredentials), typeof(RtiCredentials))
            .AddTypeMapping(typeof(IFinalSubmissionData), typeof(FinalSubmissionData));

        switch (documentType)
        {
            case RtiDocumentType.FullPaymentSubmission:
                provider
                    .AddTypeMapping(typeof(IFullPaymentSubmission), targetType)
                    .AddTypeMapping(typeof(IFullPaymentSubmissionData), typeof(FullPaymentSubmissionData))
                    .AddTypeMapping(typeof(IEmployeeDetails), typeof(EmployeeDetails))
                    .AddTypeMapping(typeof(IEmploymentData), typeof(EmploymentData))
                    .AddTypeMapping(typeof(IFpsEmploymentYtdData), typeof(FpsEmploymentYtdData))
                    .AddTypeMapping(typeof(IFpsEmploymentNationalInsuranceData), typeof(FpsEmploymentNiData))
                    .AddTypeMapping(typeof(IFpsEmploymentPaymentData), typeof(FpsEmploymentPaymentData))
                    .AddTypeMapping(typeof(IEmploymentNewStarterInfo), typeof(NewStarterInfo))
                    .AddTypeMapping(typeof(IFullPaymentSubmissionEmployeeEntry), typeof(FullPaymentSubmissionEmployeeEntry));
                break;

            case RtiDocumentType.EmployerPaymentSummary:
                provider
                    .AddTypeMapping(typeof(IEmployerPaymentSummary), targetType)
                    .AddTypeMapping(typeof(IEmployerPaymentSummaryData), typeof(EmployerPaymentSummaryData))
                    .AddTypeMapping(typeof(IRecoverableAmountsYtd), typeof(RecoverableAmountsYtd))
                    .AddTypeMapping(typeof(IApprenticeLevy), typeof(ApprenticeLevy))
                    .AddTypeMapping(typeof(IBankAccount), typeof(BankAccount));
                break;

            case RtiDocumentType.NinoVerificationRequest:
                provider
                    .AddTypeMapping(typeof(INinoVerificationRequest), targetType)
                    .AddTypeMapping(typeof(INinoVerificationRequestData), typeof(NinoVerificationRequestData))
                    .AddTypeMapping(typeof(INinoVerificationRequestEmployeeEntry), typeof(NinoVerificationRequestEmployeeEntry));
                break;
        }

        return provider.GetOptions(baseOptions);
    }
}