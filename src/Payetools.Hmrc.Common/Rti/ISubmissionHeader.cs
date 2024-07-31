// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Interface that provides access to header items for a given RTI submission.
/// </summary>
public interface ISubmissionHeader
{
    /// <summary>
    /// Gets the RTI credentials used for the submission; this is typically the Government Gateway
    /// login username and password for the employer or its agent.
    /// </summary>
    IRtiCredentials Credentials { get; init; }

    /// <summary>
    /// Gets the test transmission mode; indicates whether the message should be submitted to the
    /// test or live gateway, and in the case of the latter, whether the message should be treated as
    /// a production or test-in-live message.
    /// </summary>
    TestSubmissionMode TestSubmissionMode { get; init; }

    /// <summary>
    /// Gets the options that specify responses to the submission should be handled.
    /// </summary>
    IRtiSubmissionResponseOptions ResponseOptions { get; init; }

    /// <summary>
    /// Gets the email to be used by HMRC to send notifications regarding this submission.
    /// </summary>
    string NotificationEmail { get; init; }
}
