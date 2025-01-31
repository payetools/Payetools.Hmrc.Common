// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;
using Payetools.Hmrc.Common.Rti;
using Payetools.Payroll.Model;
using System.Security.Claims;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to all the data needed to construct an <em>Employer Payment Summary.</em>.
/// </summary>
public interface IEmployerPaymentSummaryData : IRtiDocumentDataSource
{
    /// <summary>
    /// Gets the Corporation Tax reference for the employer. May be null.
    /// </summary>
    string? CorporationTaxReference { get; }

    /// <summary>
    /// Gets the date range for a pay period when no employees are paid. Null if not
    /// applicable. Used for single/current pay period; <see cref="PeriodOfInactivity"/> is used
    /// when there is a future, potentially longer period of non-payment.
    /// </summary>
    DateRange? NoPaymentDates { get; }

    /// <summary>
    /// Gets the date range for any <strong>future</strong> period of non-payment of staff. Null
    /// if not applicable.
    /// </summary>
    DateRange? PeriodOfInactivity { get; }

    /// <summary>
    /// Gets the Employment Allowance indicator. If an employer is eligible to claim the annual
    /// NICs Employment Allowance to offset against employer Class 1 Secondary NICs, this value should
    /// be set to true, but only in the first pay period the allowance is being claimed for any one
    /// tax year. This value should only be set to false if the employer is ineligible to claim,
    /// or if a claim is being withdrawn; otherwise this value should be null.
    /// </summary>
    bool? EmploymentAllowanceIndicator { get; }

    /// <summary>
    /// Gets the type of business the employer is engaged with, needed only when the value of
    /// <see cref="EmploymentAllowanceIndicator"/> is set to true. Used to managed state aid
    /// restrictions.
    /// </summary>
    StateAidForEmploymentAllowance? DeMinimisStateAid { get; }

    /// <summary>
    /// Gets the set of year-to-date recoverable amounts for National Insurance purposes.
    /// </summary>
    IRecoverableAmountsYtd? RecoverableAmountsYtd { get; }

    /// <summary>
    /// Gets information about any Apprentice Levy, where appropriate.
    /// </summary>
    IApprenticeLevy? ApprenticeLevy { get; }

    /// <summary>
    /// Gets the bank account details of the account to be used for HMRC PAYE-related repayments.
    /// </summary>
    IBankAccount? Account { get; }

    /// <summary>
    /// Gets data associated with a final FPS, if appropriate.
    /// </summary>
    IFinalSubmissionData? FinalSubmissionData { get; }
}
