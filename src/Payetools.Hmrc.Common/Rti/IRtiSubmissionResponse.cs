// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Interface that provides access to data from the initial submission response.
/// </summary>
public interface IRtiSubmissionResponse
{
    /// <summary>
    /// Gets the Transaction ID used for the submission.
    /// </summary>
    string TransactionId { get; init; }

    /// <summary>
    /// Gets the Correllation ID provided by the gateway in response to the submission, if the
    /// submission passed initial validation.
    /// </summary>
    string? CorrelationId { get; init; }

    /// <summary>
    /// Gets the type of the response, typically indicating an acknowledeged submission
    /// (<see cref="RtiResponseType.SubmissionAcknowledgement"/>) or an error condition
    /// (<see cref="RtiResponseType.ErrorResponse"/>).
    /// </summary>
    RtiResponseType ResponseType { get; init; }

    /// <summary>
    /// Gets a Base64-encoded representation of the complete XML submission.
    /// </summary>
    string? EncodedSubmission { get; init; }

    /// <summary>
    /// Gets a Base64-encoded representation of the complete gateway response. In some circumstances, this may
    /// not be XML, in particular if the original submission was not well-formed.
    /// </summary>
    string? EncodedResponse { get; init; }
}
