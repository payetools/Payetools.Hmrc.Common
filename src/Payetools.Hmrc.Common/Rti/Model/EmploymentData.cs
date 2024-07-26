// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.NationalInsurance.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that provides access to the employee data needed to populate the
/// <em>Employment</em> element of the Full Payment Submission message.
/// </summary>
public class EmploymentData : IEmploymentData
{
    /// <summary>
    /// Gets or sets a value indicating whether the employment is treated as 'off payroll'. Defaults to
    /// false if not supplied.
    /// </summary>
    public bool? IsOffPayrollWorker { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether payments to an individual are from pension or income provided
    /// from registered pension schemes (including annuities, income from drawdown arrangements,
    /// trivial commutation payments, flexibly accessed pensions or an uncrystallised funds pension
    /// lump sum). Defaults to false if not supplied.
    /// </summary>
    public bool? IsOccupationalPensionPayment { get; set; }

    /// <summary>
    /// Gets or sets the director's NI calculation method used. Null if the employee is not a director.
    /// </summary>
    public DirectorsNiCalculationMethod? DirectorsNiCalculationMethod { get; set; }

    /// <summary>
    /// Gets or sets the tax week that a director was appointed, if that appointment took place during the
    /// current tax year.
    /// </summary>
    public uint? TaxWeekOfApptOfDirector { get; set; }

    /// <summary>
    /// Gets or sets new starter information for the employee, if appropriate.
    /// </summary>
    public IEmploymentNewStarterInfo? NewStarterInfo { get; set; }

    /// <summary>
    /// Gets or sets the payroll ID for the employee.  Includes information about any recent change.
    /// </summary>
    public string PayrollId { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the supplied payroll id has been changed.  If set to
    /// true, then the <see cref="PreviousPayrollId"/> property should be populated with the previous
    /// payroll id.
    /// </summary>
    public bool? PayrollIdChanged { get; set; }

    /// <summary>
    /// Gets or sets the previous payroll id, if appropriate. Ignored unless <see cref="PayrollIdChanged"/>
    /// is set to true.
    /// </summary>
    public string? PreviousPayrollId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this payment is not being made to an individual. Defaults to
    /// false if not supplied.
    /// </summary>
    public bool? IsPaymentToNonIndividual { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employee is paid irregularly. Defaults to
    /// false if not supplied.
    /// </summary>
    public bool? IsPaidIrregularly { get; set; }

    /// <summary>
    /// Gets or sets the employee's leaving date, if appropriate.  Null if the employee's employment is
    /// continuing.
    /// </summary>
    public DateTime? LeavingDate { get; set; }

    /// <summary>
    /// Gets the employee year to date data needed to populate the <em>Employment</em> element of
    /// the Full Payment Submission message.
    /// </summary>
    public IFpsEmploymentYtdData YtdFigures { get; init; } = default!;

    /// <summary>
    /// Gets employee pay run data needed to populate the <em>Employment</em> element of the
    /// Full Payment Submission message.
    /// </summary>
    public IFpsEmploymentPaymentData PaymentDetails { get; init; } = default!;

    /// <summary>
    /// Gets the National Insurance data needed to populate the <em>Employment</em> element of
    /// the Full Payment Submission message.
    /// </summary>
    public IFpsEmploymentNationalInsuranceData[] NiDataEntries { get; init; } = default!;
}
