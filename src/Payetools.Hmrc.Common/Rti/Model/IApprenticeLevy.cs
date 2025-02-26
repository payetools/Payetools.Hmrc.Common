// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to Apprentice Levy information.
/// </summary>
public interface IApprenticeLevy
{
    /// <summary>
    /// Gets the levy due year to date.
    /// </summary>
    decimal LevyDueYtd { get; }

    /// <summary>
    /// Gets the tax month applicable.
    /// </summary>
    string TaxMonth { get; }

    /// <summary>
    /// Gets the employer's total annual allowance under the levy scheme.
    /// </summary>
    decimal AnnualAllowance { get; }
}
