// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Enumeration that represents the various types of response that can be received from
/// the Transaction Engine.
/// </summary>
public enum RtiResponseType
{
    /// <summary>An unrecognised response was received from the Transaction Engine.</summary>
    Unrecognised,

    /// <summary>Indicates that the original submission was rejected by the Transaction Engine.</summary>
    SubmissionRejection,

    /// <summary>Indicates that the original submission was acknowledged by the Transaction Engine. The Transaction
    /// Engine must be polled for a response once the business system has digested the submission.</summary>
    SubmissionAcknowledgement,

    /// <summary>Indicates that the original submission has been processed by the Transaction Engine and
    /// the downstream business system and a business response has been returned.</summary>
    SubmissionResponse,

    /// <summary>Indicates that a delete request has been actioned by the Transaction Engine.</summary>
    DeleteResponse,

    /// <summary>
    /// Indicates that an error occurred and the response includes pertinent error information.
    /// </summary>
    ErrorResponse
}
