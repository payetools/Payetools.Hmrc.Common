// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the employee year to date data needed to populate the
/// <em>Employment</em> element of the Full Payment Submission message.
/// </summary>
/// <remarks>Note that this interface supports the omission of most of the YTD
/// fields (as in, they are nullable); the core Payetools libraries do not
/// support this capability but always provides a zero value even if no value has
/// been set.</remarks>
public interface IFpsEmploymentYtdData
{
    /// <summary>
    /// Gets the taxable pay so far this tax year.
    /// </summary>
    decimal TaxablePayYtd { get; init; }

    /// <summary>
    /// Gets the total tax paid so far this tax year.
    /// </summary>
    decimal TotalTaxYtd { get; init; }

    /// <summary>
    /// Gets the total amount of student loan deductions so far this tax year.
    /// </summary>
    decimal? StudentLoansYtd { get; init; }

    /// <summary>
    /// Gets the total amount of postgraduate loan deductions so far this tax year.
    /// </summary>
    decimal? PostgradLoansYtd { get; init; }

    /// <summary>
    /// Gets the total amount of payrolled benefits so far this tax year.
    /// </summary>
    decimal? PayrolledBenefitsYtd { get; init; }

    /// <summary>
    /// Gets the total amount of employee pension contributions paid under Net Pay Arrangements
    /// so far this tax year.
    /// </summary>
    decimal? EmployeePensionContributionsYtd { get; init; }

    /// <summary>
    /// Gets the total amount of employee pension contributions paid outside of Net Pay Arrangements
    /// so far this tax year.
    /// </summary>
    decimal? EmployeePensionContributionsNotPaidYtd { get; init; }
}
