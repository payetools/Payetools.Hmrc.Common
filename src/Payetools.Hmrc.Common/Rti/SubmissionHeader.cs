// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Entity that provides access to header items for a given RTI submission.
/// </summary>
public class SubmissionHeader : ISubmissionHeader
{
    /// <summary>
    /// Gets the RTI credentials used for the submission; this is typically the Government Gateway
    /// login username and password for the employer or its agent.
    /// </summary>
    public IRtiCredentials Credentials { get; init; } = default!;

    /// <summary>
    /// Gets the test transmission mode; indicates whether the message should be submitted to the
    /// test or live gateway, and in the case of the latter, whether the message should be treated as
    /// a production or test-in-live message.  Defaults to <see cref="TestSubmissionMode.None"/>,
    /// i.e., live production submission.
    /// </summary>
    public TestSubmissionMode TestSubmissionMode { get; init; } = TestSubmissionMode.None;

    /// <summary>
    /// Gets the options that specify responses to the submission should be handled.
    /// </summary>
    public IRtiSubmissionResponseOptions ResponseOptions { get; init; } = new RtiSubmissionResponseOptions();

    /// <summary>
    /// Gets the email to be used by HMRC to send notifications regarding this submission. Optional.
    /// </summary>
    public string? HmrcNotificationEmail { get; init; }
}