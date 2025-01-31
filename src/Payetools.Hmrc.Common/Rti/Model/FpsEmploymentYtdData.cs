// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Represents the year-to-date data for an employment entry in the FPS.
/// </summary>
public class FpsEmploymentYtdData : IFpsEmploymentYtdData
{
    /// <summary>
    /// Gets the taxable pay so far this tax year.
    /// </summary>
    public decimal TaxablePayYtd { get; init; }

    /// <summary>
    /// Gets the total tax paid so far this tax year.
    /// </summary>
    public decimal TotalTaxYtd { get; init; }

    /// <summary>
    /// Gets the total amount of student loan deductions so far this tax year.
    /// </summary>
    public decimal StudentLoansYtd { get; init; }

    /// <summary>
    /// Gets the total amount of postgraduate loan deductions so far this tax year.
    /// </summary>
    public decimal PostgradLoansYtd { get; init; }

    /// <summary>
    /// Gets the total amount of payrolled benefits so far this tax year.
    /// </summary>
    public decimal PayrolledBenefitsYtd { get; init; }

    /// <summary>
    /// Gets the total amount of employee pension contributions paid under Net Pay Arrangements
    /// so far this tax year.
    /// </summary>
    public decimal EmployeePensionContributionsYtd { get; init; }

    /// <summary>
    /// Gets the total amount of employee pension contributions paid outside of Net Pay Arrangements
    /// so far this tax year.
    /// </summary>
    public decimal EmployeePensionContributionsNotPaidYtd { get; init; }
}
