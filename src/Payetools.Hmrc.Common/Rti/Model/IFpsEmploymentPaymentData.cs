// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the employee pay run data needed to populate the
/// <em>Employment</em> element of the Full Payment Submission message.
/// </summary>
public interface IFpsEmploymentPaymentData
{
    /// <summary>
    /// Interface that provides access to car benefit information.
    /// </summary>
    public interface ICarBenefitInfo
    {
        // TODO: Complete the ICarBenefitInfo interface.
    }

    /// <summary>
    /// Interface that provides access to one or more car benefits.
    /// </summary>
    public interface IBenefit
    {
        /// <summary>
        /// Gets or sets the set of car benefits awarded to an employee.  (Maximum 15 entries.)
        /// </summary>
        ICarBenefitInfo[] Cars { get; set; }
    }

    /// <summary>
    /// Interface that provides access to information around flexible drawdown.
    /// </summary>
    public interface IFlexibleDrawdown
    {
        // TODO: Complete the IFlexibleDrawdown interface.
        // NB April 2025 onwards adds Stand alone lump sum indicator and
        // Pension commencement excess lump sum indicator
    }

    // Note: BacsHashCode omitted as it is no longer used from 2023-2024; a pattern of
    // 64 zeroes is used for earlier tax years to ensure a valid value is provided.

    /// <summary>
    /// Gets or sets the payment frequency for this payment.
    /// </summary>
    PayFrequency PayFrequency { get; set; }

    /// <summary>
    /// Gets or sets the date of this payment, typically the pay date.
    /// </summary>
    DateTime PaymentDate { get; set; }

    /// <summary>
    /// Gets or sets or sets the reason code for any late submissions.
    /// </summary>
    LateSubmissionReason? LateReason { get; set; }

    /// <summary>
    /// Gets or sets the week number for the payment. Applicable for week-based payments; should be null for
    /// monthly-based payments.
    /// </summary>
    /// <remarks>One or <see cref="WeekNumber"/> or <see cref="MonthNumber"/> must be provided.</remarks>
    int? WeekNumber { get; set; }

    /// <summary>
    /// Gets or sets the month number for the payment. Applicable for month-based payments; should be null for
    /// weekly-based payments.
    /// </summary>
    /// <remarks>One or <see cref="WeekNumber"/> or <see cref="MonthNumber"/> must be provided.</remarks>
    int? MonthNumber { get; set; }

    /// <summary>
    /// Gets or sets the number of periods covered by this payment.  Most usually 1, but can be greater for
    /// payments that cover more than one payment period.
    /// </summary>
    int NumberOfPeriodsCovered { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether earnings from more than one job have been aggregated together to
    /// calculate NI contributions. Defaults to false if not supplied.
    /// </summary>
    bool? AggregatedEarningsForNi { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this payment was made after an employee left employment.
    /// Defaults to false if not supplied.
    /// </summary>
    bool? IsPaymentAfterLeaving { get; set; }

    /// <summary>
    /// Gets or sets the normal number of hours worked by the employee, in HMRC prescribed bands.
    /// </summary>
    NormalHoursWorkedBand NormalHoursWorked { get; set; }

    /// <summary>
    /// Gets or sets the employee's tax code used for this payment.
    /// </summary>
    string TaxCode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employee's tax code is non-cumulative (i.e.,
    /// the W1/M1 flag is set).
    /// </summary>
    bool? TaxCodeIsNonCumulative { get; set; }

    /// <summary>
    /// Gets or sets the taxable pay in this pay period including payrolled benefits in kind.
    /// </summary>
    decimal TaxablePay { get; set; }

    /// <summary>
    /// Gets or sets the value of payments not subject to tax or NICs in the pay period, for example, season
    /// ticket loans.
    /// </summary>
    decimal? NonTaxOrNiPayment { get; set; }

    /// <summary>
    /// Gets or sets the value of deductions from net pay in pay period, including tax, NI and
    /// student loans, but also employee pension contributions (under RAS only), attachment of
    /// earnings orders and trade union subscriptions.
    /// </summary>
    decimal? DeductionsFromNetPay { get; set; }

    /// <summary>
    /// Gets or sets the pay after statutory deductions, not including any figure provided in the
    /// <see cref="NonTaxOrNiPayment"/> field.  Includes the value of any payrolled benefits
    /// in kind.
    /// </summary>
    decimal? PayAfterStatutoryDeductions { get; set; }

    /// <summary>
    /// Gets or sets the value of benefits taxed via payroll in the pay period.
    /// </summary>
    decimal? PayrolledBenefits { get; set; }

    /// <summary>
    /// Gets or sets the total amount of RTI-reported Class 1A NICs paid so far this tax year on
    ///  termination awards which exceed the £30,000 threshold, and/or non-contractual and
    ///  non-customary sporting testimonial payments which exceed the £100,000 threshold.
    /// </summary>
    decimal? Class1ANICsYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of employee pension contributions paid under 'net pay arrangements' in pay period.
    /// </summary>
    decimal? EmployeePensionContributionsUnderNPA { get; set; }

    /// <summary>
    /// Gets or sets the value of iItems subject to Class 1 NIC but not taxed under PAYE regulations excluding
    /// pension contributions in pay period. For example, charitable deductions (payroll giving), non-cash
    /// vouchers, payments of employee’s personal liabilities to third party such as home utility bills paid
    /// by employer.
    /// </summary>
    decimal? ItemsSubjectToClass1NIC { get; set; }

    /// <summary>
    /// Gets or sets the value of employee pension contributions paid outside of 'net pay arrangements' in pay period.
    /// </summary>
    decimal? EmployeePensionContributionsOutsideNPA { get; set; }

    /// <summary>
    /// Gets or sets the value of student loan repayments in this pay period.
    /// </summary>
    decimal? StudentLoanPayments { get; set; }

    /// <summary>
    /// Gets or sets the student loan plan type, where appropriate.
    /// </summary>
    StudentLoanType? StudentLoanType { get; set; }

    /// <summary>
    /// Gets or sets the value of postgraduate loan repayments in this pay period.
    /// </summary>
    decimal? PostgraduateLoanPayments { get; set; }

    /// <summary>
    /// Gets or sets the value of tax deducted or refunded from this payment.
    /// </summary>
    decimal TaxDeductedOrRefunded { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employee's pay has been reduced due to
    /// being on strike within the payment period. Defaults to false if not supplied.
    /// </summary>
    bool? OnStrike { get; set; }

    // Note: UnpaidAbsence is omitted as the HMRC guidance states "Do not complete this
    // field at present".

    /// <summary>
    /// Gets or sets the value of Statutory Maternity pay (SMP) year to date, if any.
    /// </summary>
    decimal? SMPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Statutory Paternity pay (SPP) year to date, if any.
    /// </summary>
    decimal? SPPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Statutory Adoption pay (SAP) year to date, if any.
    /// </summary>
    decimal? SAPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Shared Parental pay (ShPP) year to date, if any.
    /// </summary>
    decimal? ShPPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Statutory Parental Bereavement pay (SPBP) year to date, if any.
    /// </summary>
    decimal? SPBPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the value of Statutory Neonatal Care pay (SNCP) year to date, if any.
    /// </summary>
    /// <remarks>Only applicable from April 2025.</remarks>
    decimal? SNCPPaidYtd { get; set; }

    /// <summary>
    /// Gets or sets the optional BACS hash code to be included this section of the FPS.
    /// </summary>
    /// <param name="taxYearEnding">Tax year that this FPS pertains to.</param>
    /// <returns>Either a 64-char string of all zeroes, or for tax years from 2023-2024 onwards,
    /// null.</returns>
    string? GetBacsHashCode(TaxYearEnding taxYearEnding);

    // TODO: Implement Benefits (for car benefits)
    // TODO: Implement TrivialCommutationPayments
    // TODO: Implement FlexibleDrawdown
}
