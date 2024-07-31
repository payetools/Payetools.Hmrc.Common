// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Interface that provides access to options around any response to an RTI submission.
/// </summary>
public interface IRtiSubmissionResponseOptions
{
    /// <summary>
    /// Gets an optional location to address subsequent submission responses to.
    /// </summary>
    string? ReplyTo { get; init; }

    /// <summary>
    /// Gets a value indicating whether to include the full content of the submission (typically
    /// Base64-encoded) in the response.
    /// </summary>
    bool IncludeEncodedSubmissionInResponse { get; init; }

    /// <summary>
    /// Gets a value indicating whether to include the full initial response to the submission (typically
    /// Base64-encoded) in the response.
    /// </summary>
    bool IncludeEncodedResponseInResponse { get; init; }
}