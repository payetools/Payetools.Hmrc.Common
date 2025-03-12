// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Represents the payment data record portion of an employment entry in the FPS.
/// </summary>
public class FpsEmploymentPaymentData : IFpsEmploymentPaymentData
{
    /// <summary>
    /// Gets or sets the payment frequency for this payment.
    /// </summary>
    public PayFrequency PayFrequency { get; set; }

    /// <summary>
    /// Gets or sets the date of this payment, typically the pay date.
    /// </summary>
    public DateTimeOffset PaymentDate { get; set; }

    /// <summary>
    /// Gets or sets or sets the reason code for any late submissions, if applicable.
    /// </summary>
    public LateSubmissionReason? LateReason { get; set; }

    /// <summary>
    /// Gets or sets the week number for the payment. Applicable for week-based payments; should be null for
    /// monthly-based payments.
    /// </summary>
    /// <remarks>One or <see cref="WeekNumber"/> or <see cref="MonthNumber"/> must be provided.</remarks>
    public int? WeekNumber { get; set; }

    /// <summary>
    /// Gets or sets the month number for the payment. Applicable for month-based payments; should be null for
    /// weekly-based payments.
    /// </summary>
    /// <remarks>One or <see cref="WeekNumber"/> or <see cref="MonthNumber"/> must be provided.</remarks>
    public int? MonthNumber { get; set; }

    /// <summary>
    /// Gets or sets the number of periods covered by this payment.  Most usually 1, but can be greater for
    /// payments that cover more than one payment period.
    /// </summary>
    public int NumberOfPeriodsCovered { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether earnings from more than one job have been aggregated together to
    /// calculate NI contributions. Defaults to false if not supplied.
    /// </summary>
    public bool? AggregatedEarningsForNi { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this payment was made after an employee left employment. Defaults to
    /// false if not supplied.
    /// </summary>
    public bool? IsPaymentAfterLeaving { get; set; }

    /// <summary>
    /// Gets or sets the normal number of hours worked by the employee, in HMRC prescribed bands.
    /// </summary>
    public NormalHoursWorkedBand NormalHoursWorked { get; set; }

    /// <summary>
    /// Gets or sets the employee's tax code used for this payment.
    /// </summary>
    public string TaxCode { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the employee's tax code is non-cumulative (i.e.,
    /// the W1/M1 flag is set).
    /// </summary>
    public bool? TaxCodeIsNonCumulative { get; set; }

    /// <summary>
    /// Gets or sets the taxable pay in this pay period including payrolled benefits in kind.
    /// </summary>
    public decimal TaxablePay { get; set; }

    /// <summary>
    /// Gets or sets the value of payments not subject to tax or NICs in the pay period, for example,
    /// season ticket loans.
    /// </summary>
    public decimal? NonTaxOrNiPayment { get; set; }

    /// <summary>
    /// Gets or sets the value of deductions from net pay in pay period, including tax, NI and
    /// student loans, but also employee pension contributions (under RAS only), attachment of
    /// earnings orders and trade union subscriptions.
    /// </summary>
    public decimal? DeductionsFromNetPay { get; set; }

    /// <summary>
    /// Gets or sets the pay after statutory deductions, not including any figure provided in the
    /// <see cref="NonTaxOrNiPayment"/> field.  Includes the value of any payrolled benefits
    /// in kind.
    /// </summary>
    public decimal? PayAfterStatutoryDeductions { get; set; }

    /// <summary>
    /// Gets or sets the value of benefits taxed via payroll in the pay period.
    /// </summary>
    public decimal? PayrolledBenefits { get; set; }

    /// <summary>
    /// Gets or sets the total amount of RTI-reported Class 1A NICs paid so far this tax year on
    /// termination awards which exceed the £30,000 threshold, and/or non-contractual and
    /// non-customary sporting testimonial payments which exceed the £100,000 threshold.
    /// </summary>
    public decimal? Class1ANICsYtd { get; set; }

    // TODO: Implement Benefits (specifically employee car benefits, where appropriate)

    /// <summary>
    /// Gets or sets the value of employee pension contributions paid under 'net pay arrangements'
    /// in pay period.
    /// </summary>
    public decimal? EmployeePensionContributionsUnderNPA { get; set; }

    /// <summary>
    /// Gets or sets the value of items subject to Class 1 NIC but not taxed under PAYE regulations excluding
    /// pension contributions in pay period. For example, charitable deductions (payroll giving), non-cash
    /// vouchers, payments of employee’s personal liabilities to third party such as home utility bills paid
    /// by employer.
    /// </summary>
    public decimal? ItemsSubjectToClass1NIC { get; set; }

    /// <summary>
    /// Gets or sets the value of employee pension contributions paid outside of 'net pay arrangements'
    /// in pay period.
    /// </summary>
    public decimal? EmployeePensionContributionsOutsideNPA { get; set; }

    /// <summary>
    /// Gets or sets the value of student loan repayments in this pay period.
    /// </summary>
    public decimal? StudentLoanPayments { get; set; }

    /// <summary>
    /// Gets or sets the student loan plan type, where appropriate.
    /// </summary>
    public StudentLoanType? StudentLoanType { get; set; }

    /// <summary>
    /// Gets or sets the value of postgraduate loan repayments in this pay period.
    /// </summary>
    public decimal? PostgraduateLoanPayments { get; set; }

    /// <summary>
    /// Gets or sets the value of tax deducted or refunded from this payment.
    /// </summary>
    public decimal TaxDeductedOrRefunded { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employee's pay has been reduced due to
    /// being on strike within the payment period. Defaults to false if not supplied.
    /// </summary>
    public bool? OnStrike { get; set; }

    // Note: UnpaidAbsence is omitted as the HMRC guidance states "Do not complete this
    // field at present".

    /// <summary>
    /// Gets or sets the value of Statutory Maternity pay (SMP) year to date, if any.
    /// </summary>
    public decimal? SMPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Statutory Paternity pay (SPP) year to date, if any.
    /// </summary>
    public decimal? SPPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Statutory Adoption pay (SAP) year to date, if any.
    /// </summary>
    public decimal? SAPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Shared Parental pay (ShPP) year to date, if any.
    /// </summary>
    public decimal? ShPPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Statutory Parental Bereavement pay (SPBP) year to date, if any.
    /// </summary>
    public decimal? SPBPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Statutory Neonatal Care pay (SNCP) year to date, if any.
    /// </summary>
    /// <remarks>Only applicable from April 2025.</remarks>
    public decimal? SNCPPaidYtd { get; set; }

    // TODO: Implement Benefits (for car benefits)
    // TODO: Implement TrivialCommutationPayments
    // TODO: Implement FlexibleDrawdown

    /// <summary>
    /// Gets or sets the optional BACS hash code to be included this section of the FPS.
    /// </summary>
    /// <param name="taxYearEnding">Tax year that this FPS pertains to.</param>
    /// <returns>Either a 64-char string of all zeroes, or for tax years from 2023-2024 onwards,
    /// null.</returns>
    public string? GetBacsHashCode(TaxYearEnding taxYearEnding) =>
        taxYearEnding <= TaxYearEnding.Apr5_2023 ? new string('0', 64) : null;
}