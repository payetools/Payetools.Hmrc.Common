// Copyright (c) 2023-2024, Payetools Foundation.
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
    /// Gets the payment frequency for this payment.
    /// </summary>
    public PayFrequency PayFrequency { get; init; }

    /// <summary>
    /// Gets the date of this payment, typically the pay date.
    /// </summary>
    public DateTime PaymentDate { get; init; }

    /// <summary>
    /// Gets or sets the reason code for any late submissions, if applicable.
    /// </summary>
    public LateSubmissionReason? LateReason { get; set; }

    /// <summary>
    /// Gets the number of periods covered by this payment.  Most usually 1, but can be greater for
    /// payments that cover more than one payment period.
    /// </summary>
    public int NumberOfPeriodsCovered { get; init; }

    /// <summary>
    /// Gets a value indicating whether earnings from more than one job have been aggregated together to
    /// calculate NI contributions. Defaults to false if not supplied.
    /// </summary>
    public bool? AggregatedEarningsForNi { get; init; }

    /// <summary>
    /// Gets a value indicating whether this payment was made after an employee left employment. Defaults to
    /// false if not supplied.
    /// </summary>
    public bool? IsPaymentAfterLeaving { get; init; }

    /// <summary>
    /// Gets the normal number of hours worked by the employee, in HMRC prescribed bands.
    /// </summary>
    public NormalHoursWorkedBand NormalHoursWorked { get; init; }

    /// <summary>
    /// Gets the employee's tax code used for this payment.
    /// </summary>
    public string TaxCode { get; init; } = default!;

    /// <summary>
    /// Gets the taxable pay in this pay period including payrolled benefits in kind.
    /// </summary>
    public decimal TaxablePay { get; init; }

    /// <summary>
    /// Gets the value of payments not subject to tax or NICs in the pay period, for example,
    /// season ticket loans.
    /// </summary>
    public decimal? NonTaxOrNiPayment { get; init; }

    /// <summary>
    /// Gets the value of deductions from net pay in pay period, including tax, NI and
    /// student loans, but also employee pension contributions (under RAS only), attachment of
    /// earnings orders and trade union subscriptions.
    /// </summary>
    public decimal? DeductionsFromNetPay { get; init; }

    /// <summary>
    /// Gets the pay after statutory deductions, not including any figure provided in the
    /// <see cref="NonTaxOrNiPayment"/> field.  Includes the value of any payrolled benefits
    /// in kind.
    /// </summary>
    public decimal? PayAfterStatutoryDeductions { get; init; }

    /// <summary>
    /// Gets the value of benefits taxed via payroll in the pay period.
    /// </summary>
    public decimal? PayrolledBenefits { get; init; }

    /// <summary>
    /// Gets the total amount of RTI-reported Class 1A NICs paid so far this tax year on
    /// termination awards which exceed the £30,000 threshold, and/or non-contractual and
    /// non-customary sporting testimonial payments which exceed the £100,000 threshold.
    /// </summary>
    public decimal? Class1ANICsYtd { get; init; }

    // TODO: Implement Benefits (specifically employee car benefits, where appropriate)

    /// <summary>
    /// Gets the value of employee pension contributions paid under 'net pay arrangements'
    /// in pay period.
    /// </summary>
    public decimal? EmployeePensionContributionsUnderNPA { get; init; }

    /// <summary>
    /// Gets the value of items subject to Class 1 NIC but not taxed under PAYE regulations excluding
    /// pension contributions in pay period. For example, charitable deductions (payroll giving), non-cash
    /// vouchers, payments of employee’s personal liabilities to third party such as home utility bills paid
    /// by employer.
    /// </summary>
    public decimal? ItemsSubjectToClass1NIC { get; init; }

    /// <summary>
    /// Gets the value of employee pension contributions paid outside of 'net pay arrangements'
    /// in pay period.
    /// </summary>
    public decimal? EmployeePensionContributionsOutsideNPA { get; init; }

    /// <summary>
    /// Gets the value of student loan repayments in this pay period.
    /// </summary>
    public decimal? StudentLoanPayments { get; init; }

    /// <summary>
    /// Gets the student loan plan type, where appropriate.
    /// </summary>
    public StudentLoanType? StudentLoanType { get; init; }

    /// <summary>
    /// Gets the value of postgraduate loan repayments in this pay period.
    /// </summary>
    public decimal? PostgraduateLoanPayments { get; init; }

    /// <summary>
    /// Gets the value of tax deducted or refunded from this payment.
    /// </summary>
    public decimal TaxDeductedOrRefunded { get; init; }

    /// <summary>
    /// Gets a value indicating whether the employee's pay has been reduced due to
    /// being on strike within the payment period. Defaults to false if not supplied.
    /// </summary>
    public bool? OnStrike { get; init; }

    // Note: UnpaidAbsence is omitted as the HMRC guidance states "Do not complete this
    // field at present".

    /// <summary>
    /// Gets the value of Statutory Maternity pay (SMP) year to date, if any.
    /// </summary>
    public decimal? SMPPaidYtd { get; init; }

    /// <summary>
    /// Gets the value of Statutory Paternity pay (SPP) year to date, if any.
    /// </summary>
    public decimal? SPPPaidYtd { get; init; }

    /// <summary>
    /// Gets the value of Statutory Adoption pay (SAP) year to date, if any.
    /// </summary>
    public decimal? SAPPaidYtd { get; init; }

    /// <summary>
    /// Gets the value of Shared Parental pay (ShPP) year to date, if any.
    /// </summary>
    public decimal? ShPPPaidYtd { get; init; }

    /// <summary>
    /// Gets the value of Statutory Parental Bereavement pay (SPBP) year to date, if any.
    /// </summary>
    public decimal? SPBPPaidYtd { get; init; }

    // TODO: Implement Benefits (for car benefits)
    // TODO: Implement TrivialCommutationPayments
    // TODO: Implement FlexibleDrawdown

    /// <summary>
    /// Gets the optional BACS hash code to be included this section of the FPS.
    /// </summary>
    /// <param name="taxYearEnding">Tax year that this FPS pertains to.</param>
    /// <returns>Either a 64-char string of all zeroes, or for tax years from 2023-2024 onwards,
    /// null.</returns>
    public string? GetBacsHashCode(TaxYearEnding taxYearEnding) => null; // TODO: Check how this is used (BACScode)
}
