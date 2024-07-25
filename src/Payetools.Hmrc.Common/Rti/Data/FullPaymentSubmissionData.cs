// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;
using Payetools.NationalInsurance.Model;
using Payetools.Payroll.Model;

namespace Payetools.Hmrc.Common.Rti.Data;

/// <summary>
/// Represents an employee's partner details, which are needed for shared parental pay.
/// </summary>
public class EmployeePartner
{
    /// <summary>
    /// Gets the partner's National Insurance number.
    /// </summary>
    public string NiNumber { get; init; } = default!;

    /// <summary>
    /// Gets the partner's name details.
    /// </summary>
    public ContactName Name { get; init; } = default!;
}

/// <summary>
/// Entity that provides access to the employee's details.
/// </summary>
public class EmployeeDetails
{
    /// <summary>
    /// Gets the employee's National Insurance number.
    /// </summary>
    public string NiNumber { get; init; } = default!;

    /// <summary>
    /// Gets the employee's name details.
    /// </summary>
    public ContactName Name { get; init; } = default!;

    /// <summary>
    /// Gets the employee's postal address.
    /// </summary>
    public Address Address { get; init; } = default!;

    /// <summary>
    /// Gets the employee's date of birth.
    /// </summary>
    public DateTime DateOfBirth { get; init; }

    /// <summary>
    /// Gets the employee's gender.
    /// </summary>
    public Gender Gender { get; init; }

    /// <summary>
    /// Gets the employee's passport number. Optional.
    /// </summary>
    public string? PassportNumber { get; init; }

    /// <summary>
    /// Gets the employee's partner's details. Optional.
    /// </summary>
    public EmployeePartner? PartnerDetails { get; init; }
}

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

/// <summary>
/// Represents the National Insurance record portion of an employment entry in the FPS.
/// </summary>
public class FpsEmploymentNiData : IFpsEmploymentNationalInsuranceData
{
    /// <summary>
    /// Gets the NI category (aka NI letter)for this entry.
    /// </summary>
    public NiCategory NiCategory { get; init; }

    /// <summary>
    /// Gets the gross NIC-able earnings in the period.
    /// </summary>
    public decimal GrossEarningsForNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the gross NIC-able earnings in the tax year to date.  As per HMRC guidance, this figure
    /// does not include earnings that did not reach the LEL in any earnings period.
    /// </summary>
    public decimal GrossEarningsForNICsYtd { get; init; }

    /// <summary>
    /// Gets the earnings at the LEL year to date.
    /// </summary>
    public decimal AtLELYtd { get; init; }

    /// <summary>
    /// Gets the earnings above the LEL and up to and including the PT year to date.
    /// </summary>
    public decimal LELtoPTYtd { get; init; }

    /// <summary>
    /// Gets the earnings above the PT and up to and including the UEL year to date.
    /// </summary>
    public decimal PTtoUELYtd { get; init; }

    /// <summary>
    /// Gets the total employer NI contributions in the period.
    /// </summary>
    public decimal TotalEmployerNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the total employer NI contributions year to date.
    /// </summary>
    public decimal TotalEmployerNICsYtd { get; init; }

    /// <summary>
    /// Gets the total employee NI contributions in the period.
    /// </summary>
    public decimal EmployeeNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the total employee NI contributions year to date.
    /// </summary>
    public decimal EmployeeNICsYtd { get; init; }
}

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

/// <summary>
/// Entity that provides access to an employee's new starter information, where appropriate.
/// </summary>
public class NewStarterInfo
{
    /// <summary>
    /// Gets the start date for the employee.
    /// </summary>
    public DateTime StartDate { get; init; }

    /// <summary>
    /// Gets the starter declaration, A, B or C.
    /// </summary>
    public StarterDeclaration Declaration { get; init; }

    /// <summary>
    /// Gets a value indicating whether student loans should continue in the new employment.
    /// </summary>
    public bool? StudentLoanPaymentsToContinue { get; init; }

    /// <summary>
    /// Gets a value indicating whether postgraduate loans should continue in the new employment.
    /// </summary>
    public bool? PostgraduateLoanToContinue { get; init; }

    // TODO: Implement SecondmentInfo
    // TODO: Implement OccupationalPensionPayment

    // Note: The StatePension element is only used by DWP, so is not included here.
}

/// <summary>
/// Entity that provides access to the employee data needed to populate the
/// <em>Employment</em> element of the Full Payment Submission message.
/// </summary>
public class EmploymentData : IEmploymentData
{
    /// <summary>
    /// Gets a value indicating whether the employment is treated as 'off payroll'. Defaults to
    /// false if not supplied.
    /// </summary>
    public bool? IsOffPayrollWorker { get; init; }

    /// <summary>
    /// Gets a value indicating whether payments to an individual are from pension or income provided
    /// from registered pension schemes (including annuities, income from drawdown arrangements,
    /// trivial commutation payments, flexibly accessed pensions or an uncrystallised funds pension
    /// lump sum). Defaults to false if not supplied.
    /// </summary>
    public bool? IsOccupationalPensionPayment { get; init; }

    /// <summary>
    /// Gets the director's NI calculation method used. Null if the employee is not a director.
    /// </summary>
    public DirectorsNiCalculationMethod? DirectorsNiCalculationMethod { get; init; }

    /// <summary>
    /// Gets the tax week that a director was appointed, if that appointment took place during the
    /// current tax year.
    /// </summary>
    public uint? TaxWeekOfApptOfDirector { get; init; }

    /// <summary>
    /// Gets new starter information for the employee, if appropriate.
    /// </summary>
    public IEmploymentNewStarterInfo? NewStarterInfo { get; init; }

    /// <summary>
    /// Gets the payroll ID for the employee.  Includes information about any recent change.
    /// </summary>
    public string PayrollId { get; init; } = default!;

    /// <summary>
    /// Gets a value indicating whether this payment is not being made to an individual. Defaults to
    /// false if not supplied.
    /// </summary>
    public bool? IsPaymentToNonIndividual { get; init; }

    /// <summary>
    /// Gets a value indicating whether the employee is paid irregularly. Defaults to
    /// false if not supplied.
    /// </summary>
    public bool? IsPaidIrregularly { get; init; }

    /// <summary>
    /// Gets the employee's leaving date, if appropriate.  Null if the employee's employment is
    /// continuing.
    /// </summary>
    public DateTime? LeavingDate { get; init; }

    /// <summary>
    /// Gets the employee year to date data needed to populate the <em>Employment</em> element of
    /// the Full Payment Submission message.
    /// </summary>
    public IFpsEmploymentYtdData YtdFigures { get; init; } = default!;

    /// <summary>
    /// Gets the employee pay run data needed to populate the <em>Employment</em> element of the
    /// Full Payment Submission message.
    /// </summary>
    public IFpsEmploymentPaymentData PaymentDetails { get; init; } = default!;

    /// <summary>
    /// Gets the National Insurance data needed to populate the <em>Employment</em> element of
    /// the Full Payment Submission message.
    /// </summary>
    public IFpsEmploymentNationalInsuranceData[] NiDataEntries { get; init; } = default!;
}

/// <summary>
/// Entity that provides access to the data set needed to construct an employee pay run
/// entry within a Full Payment Submission.
/// </summary>
public class FullPaymentSubmissionEmployeeEntry : IFullPaymentSubmissionEmployeeEntry
{
    /// <summary>
    /// Gets the employee's details.
    /// </summary>
    public IEmployeeDetails EmployeeDetails { get; init; } = default!;

    /// <summary>
    /// Gets the employee's employment details, including payments made in
    /// the current period.
    /// </summary>
    public IEmploymentData[] EmploymentDetails { get; init; } = default!;
}

/// <summary>
/// Entity that provides access to all the data needed to construct an <em>Full Payment Submission.</em>.
/// </summary>
public class FullPaymentSubmissionData : IFullPaymentSubmissionData
{
    /// <summary>
    /// Gets the relevant period end date.
    /// </summary>
    public DateTime PeriodEnd { get; init; }

    /// <summary>
    /// Gets the optional contact details to be inserted into the IRheader.
    /// </summary>
    public IRheaderContact IRheaderContact { get; init; } = default!;

    /// <summary>
    /// Gets the message sender type.
    /// </summary>
    public IRheaderSenderType Sender { get; init; }

    /// <summary>
    /// Gets the HMRC PAYE reference for this RTI document.
    /// </summary>
    public string? HmrcPayeReference { get; init; }

    /// <summary>
    /// Gets the HMRC accounts office referece for this RTI document.
    /// </summary>
    public string? AccountsOfficeReference { get; init; }

    /// <summary>
    /// Gets the Corporation Tax reference for the employer. May be null.
    /// </summary>
    public string? CorporationTaxReference { get; init; }

    /// <summary>
    /// Gets the employee entries as an array of <see cref="FullPaymentSubmissionEmployeeEntry"/> instances.
    /// </summary>
    public IFullPaymentSubmissionEmployeeEntry[] EmployeeEntries { get; init; } = default!;

    /// <summary>
    /// Gets data associated with a final FPS, if appropriate.
    /// </summary>
    public IFinalSubmissionData? FinalSubmissionData { get; init; }
}