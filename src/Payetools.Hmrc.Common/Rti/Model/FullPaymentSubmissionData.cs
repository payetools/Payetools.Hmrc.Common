// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that provides access to all the data needed to construct an <em>Full Payment Submission.</em>.
/// </summary>
public class FullPaymentSubmissionData : IRenvelopeData, IFullPaymentSubmissionData
{
    /// <summary>
    /// Gets the Corporation Tax reference for the employer. May be null.
    /// </summary>
    public string? CorporationTaxReference { get; init; }

    /// <summary>
    /// Gets the employee entries as an array of <see cref="FullPaymentSubmissionEmployeeEntry"/> instances.
    /// </summary>
    public IFullPaymentSubmissionEmployeeEntry[] EmployeeEntries { get; init; } = default!;

    /// <summary>
    /// Gets data associated with a final FPS, if appropriate.
    /// </summary>
    public IFinalSubmissionData? FinalSubmissionData { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FullPaymentSubmissionData"/> class. Intended primarily
    /// for use in deserialisation.
    /// </summary>
    public FullPaymentSubmissionData()
    {
    }

    /// <summary>
    /// Initializes a new instance of a <see cref="FullPaymentSubmissionData"/> with the supplied parameters.
    /// </summary>
    /// <param name="envelopeData">IRenvelope data including PAYE reference and accounts office reference.</param>
    public FullPaymentSubmissionData(IRenvelopeData envelopeData)
        : base(envelopeData)
    {
    }
}