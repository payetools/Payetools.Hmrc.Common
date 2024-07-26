// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Payetools.Hmrc.Common.Serialisation;

/// <summary>
/// Provider of <see cref="JsonSerializerOptions"/> instances that enable type mapping from
/// interface types to concrete types.
/// </summary>
public class SerializationOptionsProvider
{
    private readonly List<(Type, Type)> _typeMappings = new List<(Type, Type)>();

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
}
