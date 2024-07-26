// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that provides access to the data about a final submission for a given tax year.
/// </summary>
public class FinalSubmissionData : IFinalSubmissionData
{
    /// <summary>
    /// Gets a value indicating whether the PAYE scheme has ceased, or if this is the final FPS for
    /// tax year.
    /// </summary>
    public FinalSubmissionType FinalSubmissionType { get; init; }

    /// <summary>
    /// Gets the date of the scheme ceased, where appropriate.
    /// </summary>
    public DateTime? DateSchemeCeased { get; init; }
}