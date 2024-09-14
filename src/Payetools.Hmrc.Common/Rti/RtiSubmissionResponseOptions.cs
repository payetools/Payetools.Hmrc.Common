// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Entity that provides access to options around any response to an RTI submission.
/// </summary>
public class RtiSubmissionResponseOptions : IRtiSubmissionResponseOptions
{
    /// <summary>
    /// Gets an optional value indicating whether to redact the password field of the submission credentials in
    /// any response. Defaults to true.
    /// </summary>
    public bool? RedactSubmissionPassword { get; init; } = true;

    /// <summary>
    /// Gets a value indicating whether to include the full content of the submission (typically
    /// Base64-encoded) in the response.  Defaults to not include the content.
    /// </summary>
    public bool IncludeEncodedSubmissionInResponse { get; init; }

    /// <summary>
    /// Gets a value indicating whether to include the full initial response to the submission (typically
    /// Base64-encoded) in the response.  Defaults to not include the response.
    /// </summary>
    public bool IncludeEncodedResponseInResponse { get; init; }
}