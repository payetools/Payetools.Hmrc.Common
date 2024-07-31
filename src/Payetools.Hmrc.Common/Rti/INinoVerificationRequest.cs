// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Rti.Model.Population;

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Interface that represents a full NINO verification request, including header data used to
/// populate elements of the GovTalkMessage header.
/// </summary>
public interface INinoVerificationRequest
{
    /// <summary>
    /// Gets the header data elements such as submission credentials and test mode indicator.
    /// </summary>
    ISubmissionHeader Header { get; init; }

    /// <summary>
    /// Gets the submission content.
    /// </summary>
    INinoVerificationRequestData Submission { get; init; }
}
