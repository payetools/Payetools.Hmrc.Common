// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Enumeration that corresponds to the possible reasons for making a late FPS submission.
/// </summary>
public enum LateSubmissionReason
{
    /// <summary>Notional payment: Payment to Expat by third party or overseas employer</summary>
    A,

    /// <summary>Notional payment: Employment related security</summary>
    B,

    /// <summary>Notional payment: Other</summary>
    C,

    /// <summary>Payment subject to Class 1 NICs but P11D/P9D for tax</summary>
    D,

    /// <summary>Micro Employer using temporary "on or before" relaxation</summary>
    E,

    /// <summary>No requirement to maintain a Deductions Working Sheet or Impractical to report work done on the day</summary>
    F,

    /// <summary>Reasonable excuse</summary>
    G,

    /// <summary>Correction to earlier submission</summary>
    H
}