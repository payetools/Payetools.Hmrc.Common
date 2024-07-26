// Copyright (c) 2023-2024 Payetools Foundation.  All rights reserved.
//
// This source code is the intellectual property of Payetools Foundation
// and for information security purposes is classified as CONFIDENTIAL.

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
