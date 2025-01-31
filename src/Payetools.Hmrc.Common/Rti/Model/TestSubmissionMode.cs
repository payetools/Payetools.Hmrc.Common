// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Enumeration that represents the different test modes that can be used when submitting RTI messages.
/// </summary>
public enum TestSubmissionMode
{
    /// <summary>Not in test mode; use for live production submission.</summary>
    None,

    /// <summary>Submitting to the test transaction engine.</summary>
    TestGateway,

    /// <summary>Submitting to the live transaction engine but as a test-in-live message.</summary>
    TestInLive
}
