// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that provides access to apprentice levy information.
/// </summary>
public class ApprenticeLevy : IApprenticeLevy
{
    /// <summary>
    /// Gets the levy due year to date.
    /// </summary>
    public decimal LevyDueYtd { get; init; }

    /// <summary>
    /// Gets the tax month applicable.
    /// </summary>
    public string TaxMonth { get; init; }

    /// <summary>
    /// Gets the employer's total annual allowance under the levy scheme.
    /// </summary>
    public decimal AnnualAllowance { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApprenticeLevy"/> class.
    /// </summary>
    /// <param name="levyDueYtd">Levy due year to date.</param>
    /// <param name="taxMonth">Tax month applicable.</param>
    /// <param name="annualAllowance">Employer's annual allowance under the levy scheme.</param>
    public ApprenticeLevy(decimal levyDueYtd, string taxMonth, decimal annualAllowance)
    {
        LevyDueYtd = levyDueYtd;
        TaxMonth = taxMonth;
        AnnualAllowance = annualAllowance;
    }
}
