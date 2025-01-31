// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.NationalInsurance.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the data set needed to construct an employee pay run
/// entry within a Full Payment Submission.
/// </summary>
public interface IEmploymentData
{
    /// <summary>
    /// Gets or sets a value indicating whether the employment is treated as 'off payroll'.
    /// Defaults to false if not supplied.
    /// </summary>
    bool? IsOffPayrollWorker { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether payments to an individual are from pension or income provided
    /// from registered pension schemes (including annuities, income from drawdown arrangements,
    /// trivial commutation payments, flexibly accessed pensions or an uncrystallised funds pension
    /// lump sum). Defaults to false if not supplied.
    /// </summary>
    bool? IsOccupationalPensionPayment { get; set; }

    /// <summary>
    /// Gets or sets the director's NI calculation method used. Null if the employee is not a director.
    /// </summary>
    DirectorsNiCalculationMethod? DirectorsNiCalculationMethod { get; set; }

    /// <summary>
    /// Gets or sets the tax week that a director was appointed, if that appointment took place during the
    /// current tax year.
    /// </summary>
    uint? TaxWeekOfApptOfDirector { get; set; }

    /// <summary>
    /// Gets or sets new starter information for the employee, if appropriate.
    /// </summary>
    IEmploymentNewStarterInfo? NewStarterInfo { get; set; }

    /// <summary>
    /// Gets or sets the employee's workplace postcode, applicable when the employees' National Insurance
    /// category indicates they are working in a Freeport or Investment Zone.
    /// </summary>
    /// <remarks>Only applicable from April 2025.</remarks>
    string? EmployeeWorkplacePostcode { get; set; }

    /// <summary>
    /// Gets or sets the payroll ID for the employee.  Includes information about any recent change.
    /// </summary>
    string PayrollId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the supplied payroll id has been changed.  If set to
    /// true, then the <see cref="PreviousPayrollId"/> property should be populated with the previous
    /// payroll id.
    /// </summary>
    bool? PayrollIdChanged { get; set; }

    /// <summary>
    /// Gets or sets the previous payroll id, if appropriate. Ignored unless <see cref="PayrollIdChanged"/>
    /// is set to true.
    /// </summary>
    string? PreviousPayrollId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this payment is not being made to an individual.
    /// Defaults to false if not supplied.
    /// </summary>
    bool? IsPaymentToNonIndividual { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employee is paid irregularly. Defaults to false
    /// if not supplied.
    /// </summary>
    bool? IsPaidIrregularly { get; set; }

    /// <summary>
    /// Gets or sets the employee's leaving date, if appropriate.  Null if the employee's employment is
    /// continuing.
    /// </summary>
    DateTime? LeavingDate { get; set; }

    /// <summary>
    /// Gets the employee year to date data needed to populate the <em>Employment</em> element of
    /// the Full Payment Submission message.
    /// </summary>
    IFpsEmploymentYtdData YtdFigures { get; init; }

    /// <summary>
    /// Gets the employee pay run data needed to populate the <em>Employment</em> element of the
    /// Full Payment Submission message.
    /// </summary>
    IFpsEmploymentPaymentData PaymentDetails { get; init; }

    /// <summary>
    /// Gets the National Insurance data needed to populate the <em>Employment</em> element of
    /// the Full Payment Submission message.
    /// </summary>
    IFpsEmploymentNationalInsuranceData[] NiDataEntries { get; init; }
}