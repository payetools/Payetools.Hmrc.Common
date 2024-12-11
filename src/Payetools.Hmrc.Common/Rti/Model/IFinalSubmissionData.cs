// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Enumeration that indicates what type of final FPS or EPS is being submitted, where appropriate.
/// </summary>
public enum FinalSubmissionType
{
    /// <summary>
    /// PAYE scheme is ceasing.
    /// </summary>
    SchemeCeasing,

    /// <summary>
    /// Final FPS or EPS for the tax year, typically submitted in March or April.
    /// </summary>
    FinalSubmissionForTaxYear
}

/// <summary>
/// Interface that represents the data about a final submission for a given tax year.
/// </summary>
public interface IFinalSubmissionData
{
    /// <summary>
    /// Gets a value indicating whether the PAYE scheme has ceased, or if this is the final FPS for
    /// tax year.
    /// </summary>
    FinalSubmissionType FinalSubmissionType { get; }

    /// <summary>
    /// Gets the date of the scheme ceased, where appropriate.
    /// </summary>
    DateTime? DateSchemeCeased { get; }
}