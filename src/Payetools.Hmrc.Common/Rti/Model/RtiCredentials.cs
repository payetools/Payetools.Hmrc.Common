// Copyright (c) 2023-2024 Payetools Foundation.  All rights reserved.
//
// This source code is the intellectual property of Payetools Foundation
// and for information security purposes is classified as CONFIDENTIAL.

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Rti.Model;

/// <summary>
/// Represents the set of credentials used to authenticate with the RTI service.
/// </summary>
public class RtiCredentials : IRtiCredentials
{
    /// <summary>
    /// Gets the sender identifier for this set of credentials.  This is typically the
    /// Government Gateway ID being used for RTI submissions.
    /// </summary>
    public string SenderId { get; init; }

    /// <summary>
    /// Gets the password.  This is typically the Government Gateway password being
    /// used for RTI submissions.
    /// </summary>
    public string Password { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RtiCredentials"/> class.
    /// </summary>
    /// <param name="senderId">See <see cref="SenderId"/>.</param>
    /// <param name="password">See <see cref="Password"/>.</param>
    public RtiCredentials(string senderId, string password)
    {
        SenderId = senderId;
        Password = password;
    }
}
