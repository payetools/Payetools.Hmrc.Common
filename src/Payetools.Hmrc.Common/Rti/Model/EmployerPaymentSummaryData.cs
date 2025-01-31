// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;
using Payetools.Payroll.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that contains  the data set needed to populate a Employer Payment Summary.
/// </summary>
public class EmployerPaymentSummaryData : IRenvelopeData, IEmployerPaymentSummaryData
{
    /// <summary>
    /// Gets the Corporation Tax reference for the employer. May be null.
    /// </summary>
    public string? CorporationTaxReference { get; }

    /// <summary>
    /// Gets the date range for a pay period when no employees are paid. Null if not
    /// applicable. Used for single/current pay period; <see cref="PeriodOfInactivity"/> is used
    /// when there is a future, potentially longer period of non-payment.
    /// </summary>
    public DateRange? NoPaymentDates { get; }

    /// <summary>
    /// Gets the date range for any <strong>future</strong> period of non-payment of staff. Null
    /// if not applicable.
    /// </summary>
    public DateRange? PeriodOfInactivity { get; }

    /// <summary>
    /// Gets the Employment Allowance indicator. If an employer is eligible to claim the annual
    /// NICs Employment Allowance to offset against employer Class 1 Secondary NICs, this value should
    /// be set to true, but only in the first pay period the allowance is being claimed for any one
    /// tax year. This value should only be set to false if the employer is ineligible to claim,
    /// or if a claim is being withdrawn; otherwise this value should be null.
    /// </summary>
    public bool? EmploymentAllowanceIndicator { get; }

    /// <summary>
    /// Gets the type of business the employer is engaged with, needed only when the value of
    /// <see cref="EmploymentAllowanceIndicator"/> is set to true. Used to managed state aid
    /// restrictions.
    /// </summary>
    public StateAidForEmploymentAllowance? DeMinimisStateAid { get; }

    /// <summary>
    /// Gets the set of year-to-date recoverable amounts for National Insurance purposes.
    /// </summary>
    public IRecoverableAmountsYtd? RecoverableAmountsYtd { get; }

    /// <summary>
    /// Gets information about any Apprentice Levy, where appropriate.
    /// </summary>
    public IApprenticeLevy? ApprenticeLevy { get; }

    /// <summary>
    /// Gets the bank account details of the account to be used for HMRC PAYE-related repayments.
    /// </summary>
    public IBankAccount? Account { get; }

    /// <summary>
    /// Gets data associated with a final FPS, if appropriate.
    /// </summary>
    public IFinalSubmissionData? FinalSubmissionData { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmployerPaymentSummaryData"/> class.
    /// </summary>
    /// <param name="envelopeData">IRenvelope data including PAYE reference and accounts office reference.</param>
    /// <param name="corporationTaxReference">Corporation tax reference, if available. May be null.</param>
    /// <param name="noPaymentDates">Pay period dates when employees are not being paid. May be null.</param>
    /// <param name="periodOfInactivity">Future date range when employees are not being paid. May be null.</param>
    /// <param name="employmentAllowanceIndicator">Set to true to indicate EA is being claimed; set to false
    /// to indicate an EA claim is being withdrawn. Should only be set once per tax year. May be null.</param>
    /// <param name="deMinimisStateAid">Industry sector of employer, where appropriate. Include if
    /// <paramref name="employmentAllowanceIndicator"/> is set to true.</param>
    /// <param name="recoverableAmountsYtd">Year-to-date recoverable amounts. May be null.</param>
    /// <param name="apprenticeLevy">Apprentice levy information, if appropriate. Otherwise null.</param>
    /// <param name="account">Bank account for repayments, if available. Otherwise null.</param>
    /// <param name="finalSubmissionData">Final submission information, if appropriate. Otherwise null.</param>
    public EmployerPaymentSummaryData(
        IRenvelopeData envelopeData,
        string? corporationTaxReference,
        DateRange? noPaymentDates,
        DateRange? periodOfInactivity,
        bool? employmentAllowanceIndicator,
        StateAidForEmploymentAllowance? deMinimisStateAid,
        IRecoverableAmountsYtd? recoverableAmountsYtd,
        IApprenticeLevy? apprenticeLevy,
        IBankAccount? account,
        IFinalSubmissionData? finalSubmissionData = null)
        : base(envelopeData)
    {
        if (noPaymentDates != null && periodOfInactivity != null)
            throw new ArgumentException("Only one of noPaymentDates or periodOfInactivity may be specified", nameof(noPaymentDates));

        if ((periodOfInactivity != null || noPaymentDates != null) && recoverableAmountsYtd != null)
            throw new ArgumentException("Recoverable amounts (YTD) should not be specified when no employees are being paid", nameof(recoverableAmountsYtd));

        if (employmentAllowanceIndicator == true && deMinimisStateAid == null)
            throw new ArgumentException("deMinimisStateAid must be specified when employmentAllowanceIndicator is set to true", nameof(deMinimisStateAid));

        CorporationTaxReference = corporationTaxReference;
        NoPaymentDates = noPaymentDates;
        PeriodOfInactivity = periodOfInactivity;
        EmploymentAllowanceIndicator = employmentAllowanceIndicator;
        DeMinimisStateAid = deMinimisStateAid;
        RecoverableAmountsYtd = recoverableAmountsYtd;
        ApprenticeLevy = apprenticeLevy;
        Account = account;
        FinalSubmissionData = finalSubmissionData;
    }
}