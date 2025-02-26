// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to all the data needed to construct an <em>Full Payment Submission.</em>.
/// </summary>
public interface IFullPaymentSubmissionData : IRtiDocumentDataSource
{
    /// <summary>
    /// Gets the Corporation Tax reference for the employer. May be null.
    /// </summary>
    string? CorporationTaxReference { get; init; }

    /// <summary>
    /// Gets the pay run results as an IEnumerable of <see cref="IFullPaymentSubmissionEmployeeEntry"/>.
    /// </summary>
    IFullPaymentSubmissionEmployeeEntry[] EmployeeEntries { get; init; }

    /// <summary>
    /// Gets data associated with a final FPS, if appropriate.
    /// </summary>
    IFinalSubmissionData? FinalSubmissionData { get; init; }
}