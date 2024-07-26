// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to occupational pension payment information.
/// </summary>
public interface IPensionPayment
{
    /// <summary>
    /// Gets a value indicating whether the employee is bereaved.
    /// </summary>
    bool? IsBereaved { get; init; }

    /// <summary>
    /// Gets the amount of the payment.
    /// </summary>
    decimal Amount { get; init; }
}
