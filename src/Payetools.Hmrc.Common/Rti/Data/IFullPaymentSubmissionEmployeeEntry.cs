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
/// Interface that provides access to the data set needed to construct an employee pay run
/// entry within a Full Payment Submission.
/// </summary>
public interface IFullPaymentSubmissionEmployeeEntry
{
    /// <summary>
    /// Interface that provides access to the employee's details.
    /// </summary>
    public interface IEmployeeDetails
    {
        /// <summary>
        /// Gets the employee's National Insurance number.
        /// </summary>
        NiNumber NiNumber { get; }

        /// <summary>
        /// Gets the employee's name details.
        /// </summary>
        ContactName Name { get; }

        /// <summary>
        /// Gets the employee's postal address.
        /// </summary>
        PostalAddress Address { get; }

        /// <summary>
        /// Gets the employee's date of birth.
        /// </summary>
        DateTime DateOfBirth { get; }

        /// <summary>
        /// Gets the employee's gender.
        /// </summary>
        Gender Gender { get; }

        /// <summary>
        /// Gets the employee's passport number.  Optional.
        /// </summary>
        string? PassportNumber { get; }

        /// <summary>
        /// Gets the employee's partner's details.  Optional.
        /// </summary>
        EmployeePartner? PartnerDetails { get; }
    }

    /// <summary>
    /// Interface that provides access to secondment information for an employee.
    /// </summary>
    public interface ISecondmentInfo
    {
        // TODO: Complete the ISecondmentInfo interface.
    }

    /// <summary>
    /// Interface that provides access to occupational pension payment information.
    /// </summary>
    public interface IPensionPayment
    {
        /// <summary>
        /// Gets a value indicating whether the employee is bereaved.
        /// </summary>
        bool IsBereaved { get; }

        /// <summary>
        /// Gets the amount of the payment.
        /// </summary>
        decimal Amount { get; }
    }

    /// <summary>
    /// Interface that provides access to the employee's employment details, including payments made in
    /// the current period.
    /// </summary>
    public interface IEmploymentData
    {
        /// <summary>
        /// Interface that provides access to an employee's new starter information, where appropriate.
        /// </summary>
        public interface IEmploymentNewStarterInfo
        {
            /// <summary>
            /// Gets the start date for the employee.
            /// </summary>
            DateTime StartDate { get; }

            /// <summary>
            /// Gets the starter declaration, A, B or C.
            /// </summary>
            StarterDeclaration Declaration { get; }

            /// <summary>
            /// Gets a value indicating whether student loans should continue in the new employment.
            /// </summary>
            bool? StudentLoanPaymentsToContinue { get; }

            /// <summary>
            /// Gets a value indicating whether postgraduate loans should continue in the new employment.
            /// </summary>
            bool? PostgraduateLoanToContinue { get; }

            /// <summary>
            /// Gets secondment information for the employee, if relevant.  Null if not applicable.
            /// </summary>
            ISecondmentInfo? SecondmentInfo { get; }

            /// <summary>
            /// Gets occupational pension payment information, if appropriate.
            /// </summary>
            IPensionPayment? OccupationalPensionPayment { get; }

            // Note: The StatePension element is only used by DWP, so is not included here.
        }

        /// <summary>
        /// Interface that provides access to the employee year to date data needed to populate the
        /// <em>Employment</em> element of the Full Payment Submission message.
        /// </summary>
        public interface IFpsEmploymentYtdData
        {
            /// <summary>
            /// Gets the taxable pay so far this tax year.
            /// </summary>
            decimal TaxablePayYtd { get; }

            /// <summary>
            /// Gets the total tax paid so far this tax year.
            /// </summary>
            decimal TotalTaxYtd { get; }

            /// <summary>
            /// Gets the total amount of student loan deductions so far this tax year.
            /// </summary>
            decimal StudentLoansYtd { get; }

            /// <summary>
            /// Gets the total amount of postgraduate loan deductions so far this tax year.
            /// </summary>
            decimal PostgradLoansYtd { get; }

            /// <summary>
            /// Gets the total amount of payrolled benefits so far this tax year.
            /// </summary>
            decimal PayrolledBenefitsYtd { get; }

            /// <summary>
            /// Gets the total amount of employee pension contributions paid under Net Pay Arrangements
            /// so far this tax year.
            /// </summary>
            decimal EmployeePensionContributionsYtd { get; }

            /// <summary>
            /// Gets the total amount of employee pension contributions paid outside of Net Pay Arrangements
            /// so far this tax year.
            /// </summary>
            decimal EmployeePensionContributionsNotPaidYtd { get; }
        }

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
                /// Gets the set of car benefits awarded to an employee.  (Maximum 15 entries.)
                /// </summary>
                ICarBenefitInfo[] Cars { get; }
            }

            /// <summary>
            /// Interface that provides access to information around flexible drawdown.
            /// </summary>
            public interface IFlexibleDrawdown
            {
                // TODO: Complete the IFlexibleDrawdown interface.
            }

            /// <summary>
            /// Interface that provides access to lump-sum payment information.
            /// </summary>
            public interface ITrivialCommutationPayment
            {
                // TODO: Complete the ITrivialCommutationPayment interface.
            }

            // Note: BacsHashCode omitted as it is no longer used from 2023-2024; a pattern of
            // 64 zeroes is used for earlier tax years to ensure a valid value is provided.

            /// <summary>
            /// Gets the payment frequency for this payment.
            /// </summary>
            PayFrequency PayFrequency { get; }

            /// <summary>
            /// Gets the date of this payment, typically the pay date.
            /// </summary>
            DateTime PaymentDate { get; }

            /// <summary>
            /// Gets or sets the reason code for any late submissions.
            /// </summary>
            LateSubmissionReason? LateReason { get; set; }

            /// <summary>
            /// Gets the week number for the payment. Applicable for week-based payments; should be null for
            /// monthly-based payments.
            /// </summary>
            /// <remarks>One or <see cref="WeekNumber"/> or <see cref="MonthNumber"/> must be provided.</remarks>
            int? WeekNumber { get; }

            /// <summary>
            /// Gets the month number for the payment. Applicable for month-based payments; should be null for
            /// weekly-based payments.
            /// </summary>
            /// <remarks>One or <see cref="WeekNumber"/> or <see cref="MonthNumber"/> must be provided.</remarks>
            int? MonthNumber { get; }

            /// <summary>
            /// Gets the number of periods covered by this payment.  Most usually 1, but can be greater for
            /// payments that cover more than one payment period.
            /// </summary>
            int NumberOfPeriodsCovered { get; }

            /// <summary>
            /// Gets a value indicating whether earnings from more than one job have been aggregated together to
            /// calculate NI contributions.
            /// </summary>
            bool AggregatedEarningsForNi { get; }

            /// <summary>
            /// Gets a value indicating whether this payment was made after an employee left employment.
            /// </summary>
            bool IsPaymentAfterLeaving { get; }

            /// <summary>
            /// Gets the normal number of hours worked by the employee, in HMRC prescribed bands.
            /// </summary>
            NormalHoursWorkedBand NormalHoursWorked { get; }

            /// <summary>
            /// Gets the employee's tax code used for this payment.
            /// </summary>
            TaxCode TaxCode { get; }

            /// <summary>
            /// Gets the taxable pay in this pay period including payrolled benefits in kind.
            /// </summary>
            decimal TaxablePay { get; }

            /// <summary>
            /// Gets the value of payments not subject to tax or NICs in the pay period, for example, season
            /// ticket loans.
            /// </summary>
            decimal? NonTaxOrNiPayment { get; }

            /// <summary>
            /// Gets the value of deductions from net pay in pay period, including tax, NI and
            /// student loans, but also employee pension contributions (under RAS only), attachment of
            /// earnings orders and trade union subscriptions.
            /// </summary>
            decimal? DeductionsFromNetPay { get; }

            /// <summary>
            /// Gets the pay after statutory deductions, not including any figure provided in the
            /// <see cref="NonTaxOrNiPayment"/> field.  Includes the value of any payrolled benefits
            /// in kind.
            /// </summary>
            decimal? PayAfterStatutoryDeductions { get; }

            /// <summary>
            /// Gets the value of benefits taxed via payroll in the pay period.
            /// </summary>
            decimal? PayrolledBenefits { get; }

            /// <summary>
            /// Gets the total amount of RTI-reported Class 1A NICs paid so far this tax year on
            ///  termination awards which exceed the £30,000 threshold, and/or non-contractual and
            ///  non-customary sporting testimonial payments which exceed the £100,000 threshold.
            /// </summary>
            decimal? Class1ANICsYtd { get; }

            /// <summary>
            /// Gets access to employee car benefits, where appropriate.
            /// </summary>
            IBenefit? Benefits { get; }

            /// <summary>
            /// Gets the value of employee pension contributions paid under 'net pay arrangements' in pay period.
            /// </summary>
            decimal? EmployeePensionContributionsUnderNPA { get; }

            /// <summary>
            /// Gets the value of iItems subject to Class 1 NIC but not taxed under PAYE regulations excluding
            /// pension contributions in pay period. For example, charitable deductions (payroll giving), non-cash
            /// vouchers, payments of employee’s personal liabilities to third party such as home utility bills paid
            /// by employer.
            /// </summary>
            decimal? ItemsSubjectToClass1NIC { get; }

            /// <summary>
            /// Gets the value of employee pension contributions paid outside of 'net pay arrangements' in pay period.
            /// </summary>
            decimal? EmployeePensionContributionsOutsideNPA { get; }

            /// <summary>
            /// Gets the value of student loan repayments in this pay period.
            /// </summary>
            decimal? StudentLoanPayments { get; }

            /// <summary>
            /// Gets the student loan plan type, where appropriate.
            /// </summary>
            StudentLoanType? StudentLoanType { get; }

            /// <summary>
            /// Gets the value of postgraduate loan repayments in this pay period.
            /// </summary>
            decimal? PostgraduateLoanPayments { get; }

            /// <summary>
            /// Gets the value of tax deducted or refunded from this payment.
            /// </summary>
            decimal TaxDeductedOrRefunded { get; }

            /// <summary>
            /// Gets a value indicating whether the employee's pay has been reduced due to
            /// being on strike within the payment period.
            /// </summary>
            bool OnStrike { get; }

            // Note: UnpaidAbsence is omitted as the HMRC guidance states "Do not complete this
            // field at present".

            /// <summary>
            /// Gets the value of Statutory Maternity pay (SMP) year to date, if any.
            /// </summary>
            decimal? SMPPaidYtd { get; }

            /// <summary>
            /// Gets the value of Statutory Paternity pay (SPP) year to date, if any.
            /// </summary>
            decimal? SPPPaidYtd { get; }

            /// <summary>
            /// Gets the value of Statutory Adoption pay (SAP) year to date, if any.
            /// </summary>
            decimal? SAPPaidYtd { get; }

            /// <summary>
            /// Gets the value of Shared Parental pay (ShPP) year to date, if any.
            /// </summary>
            decimal? ShPPPaidYtd { get; }

            /// <summary>
            /// Gets the value of Statutory Parental Bereavement pay (SPBP) year to date, if any.
            /// </summary>
            decimal? SPBPPaidYtd { get; }

            /// <summary>
            /// Gets information around pension lump-sum payments.
            /// </summary>
            ITrivialCommutationPayment[]? TrivialCommutationPayments { get; }

            /// <summary>
            /// Gets information regarding flexible drawdown in this payment period.
            /// </summary>
            IFlexibleDrawdown? FlexibleDrawdown { get; }

            /// <summary>
            /// Gets the optional BACS hash code to be included this section of the FPS.
            /// </summary>
            /// <param name="taxYearEnding">Tax year that this FPS pertains to.</param>
            /// <returns>Either a 64-char string of all zeroes, or for tax years from 2023-2024 onwards,
            /// null.</returns>
            string? GetBacsHashCode(TaxYearEnding taxYearEnding);
        }

        /// <summary>
        /// Interface that provides access to the National Insurance data needed to populate the
        /// <em>Employment</em> element of the Full Payment Submission message.
        /// </summary>
        public interface IFpsEmploymentNationalInsuranceData
        {
            /// <summary>
            /// Gets the NI category (aka NI letter)for this entry.
            /// </summary>
            NiCategory NiCategory { get; }

            /// <summary>
            /// Gets the gross NIC-able earnings in the period.
            /// </summary>
            decimal GrossEarningsForNICsInPeriod { get; }

            /// <summary>
            /// Gets the gross NIC-able earnings in the tax year to date.  As per HMRC guidance, this figure
            /// does not include earnings that did not reach the LEL in any earnings period.
            /// </summary>
            decimal GrossEarningsForNICsYtd { get; }

            /// <summary>
            /// Gets the earnings at the LEL year to date.
            /// </summary>
            decimal AtLELYtd { get; }

            /// <summary>
            /// Gets the earnings above the LEL and up to and including the PT year to date.
            /// </summary>
            decimal LELtoPTYtd { get; }

            /// <summary>
            /// Gets the earnings above the PT and up to and including the UEL year to date.
            /// </summary>
            decimal PTtoUELYtd { get; }

            /// <summary>
            /// Gets the total employer NI contributions in the period.
            /// </summary>
            decimal TotalEmployerNICsInPeriod { get; }

            /// <summary>
            /// Gets the total employer NI contributions year to date.
            /// </summary>
            decimal TotalEmployerNICsYtd { get; }

            /// <summary>
            /// Gets the total employee NI contributions in the period.
            /// </summary>
            decimal EmployeeNICsInPeriod { get; }

            /// <summary>
            /// Gets the total employee NI contributions year to date.
            /// </summary>
            decimal EmployeeNICsYtd { get; }
        }

        /// <summary>
        /// Gets a value indicating whether the employment is treated as 'off payroll'.
        /// </summary>
        bool IsOffPayrollWorker { get; }

        /// <summary>
        /// Gets a value indicating whether payments to an individual are from pension or income provided
        /// from registered pension schemes (including annuities, income from drawdown arrangements,
        /// trivial commutation payments, flexibly accessed pensions or an uncrystallised funds pension
        /// lump sum).
        /// </summary>
        bool IsOccupationalPensionPayment { get; }

        /// <summary>
        /// Gets the director's NI calculation method used. Null if the employee is not a director.
        /// </summary>
        DirectorsNiCalculationMethod? DirectorsNiCalculationMethod { get; }

        /// <summary>
        /// Gets the tax week that a director was appointed, if that appointment took place during the
        /// current tax year.
        /// </summary>
        uint? TaxWeekOfApptOfDirector { get; }

        /// <summary>
        /// Gets new starter information for the employee, if appropriate.
        /// </summary>
        IEmploymentNewStarterInfo? NewStarterInfo { get; }

        /// <summary>
        /// Gets the payroll ID for the employee.  Includes information about any recent change.
        /// </summary>
        PayrollId PayrollId { get; }

        /// <summary>
        /// Gets a value indicating whether this payment is not being made to an individual.
        /// </summary>
        bool IsPaymentToNonIndividual { get; }

        /// <summary>
        /// Gets a value indicating whether the employee is paid irregularly.
        /// </summary>
        bool IsPaidIrregularly { get; }

        /// <summary>
        /// Gets the employee's leaving date, if appropriate.  Null if the employee's employment is
        /// continuing.
        /// </summary>
        DateTime? LeavingDate { get; }

        /// <summary>
        /// Gets the employee year to date data needed to populate the <em>Employment</em> element of
        /// the Full Payment Submission message.
        /// </summary>
        IFpsEmploymentYtdData YtdFigures { get; }

        /// <summary>
        /// Gets the employee pay run data needed to populate the <em>Employment</em> element of the
        /// Full Payment Submission message.
        /// </summary>
        IFpsEmploymentPaymentData PaymentDetails { get; }

        /// <summary>
        /// Gets the National Insurance data needed to populate the <em>Employment</em> element of
        /// the Full Payment Submission message.
        /// </summary>
        IFpsEmploymentNationalInsuranceData[] NiDataEntries { get; }
    }

    /// <summary>
    /// Gets the employee's details.
    /// </summary>
    IEmployeeDetails EmployeeDetails { get; }

    /// <summary>
    /// Gets the employee's employment details, including payments made in the current period.
    /// </summary>
    IEmploymentData[] EmploymentDetails { get; }
}