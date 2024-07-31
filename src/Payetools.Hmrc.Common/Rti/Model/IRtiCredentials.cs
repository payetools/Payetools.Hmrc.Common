// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the set of credentials used to authenticate with the RTI service.
/// </summary>
public interface IRtiCredentials
{
    /// <summary>
    /// Gets the sender identifier for this set of credentials.  This is typically the
    /// Government Gateway ID being used for RTI submissions.
    /// </summary>
    string Password { get; init; }

    /// <summary>
    /// Gets the password.  This is typically the Government Gateway password being
    /// used for RTI submissions.
    /// </summary>
    string SenderId { get; init; }
}