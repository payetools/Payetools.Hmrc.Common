// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Dps;

/// <summary>
/// Enumeration that details the type of an HMRC notification.
/// </summary>
public enum DpsMessageType
{
    /// <summary>Tax code update notification (includes P6 and P6b) which may
    /// include details of previous pay and tax.</summary>
    P6,

    /// <summary>Tax code only update notifications</summary>
    P9,

    /// <summary>Student loan start instruction</summary>
    SL1,

    /// <summary>Student loan stop instruction</summary>
    SL2,

    /// <summary>Postgraduate loan start instruction</summary>
    PGL1,

    /// <summary>Postgraduate loan stop instruction</summary>
    PGL2,

    /// <summary>Includes AR6, AR1n, AR2n, AR1mn and AR2mn</summary>
    AR,

    /// <summary>P35Notification, P11DbNotification and Incentive</summary>
    NOT,

    /// <summary>NOT and NVR, and Generic Notifications (GEN)</summary>
    RTI
}