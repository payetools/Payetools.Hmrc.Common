// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Interface that represents the full set of data needed to make an Full Payment Submission,
/// including header data used to populate elements of the GovTalkMessage header.
/// </summary>
public interface IFullPaymentSubmission
{
    /// <summary>
    /// Gets the header data elements such as submission credentials and test mode indicator.
    /// </summary>
    ISubmissionHeader Header { get; init; }

    /// <summary>
    /// Gets the submission content.
    /// </summary>
    IFullPaymentSubmissionData Submission { get; init; }
}