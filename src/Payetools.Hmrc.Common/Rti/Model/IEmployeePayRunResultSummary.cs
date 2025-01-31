// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides the summary of the employee pay run result, without the
/// calculation details normally provided by the payrun calculation engine.  This
/// interface is more suitable for persisting the results of a pay run.
/// </summary>
public interface IEmployeePayRunResultSummary
{
    /// <summary>
    /// Gets the employee's pension contribution made outside of Net Pay Arrangment (NPA)
    /// in the pay period.
    /// </summary>
    public decimal? EmployeePensionContributionsOutsideNpa { get; }

    /// <summary>
    /// Gets the employee's pension contribution made within a Net Pay Arrangment (NPA)
    /// in the pay period.
    /// </summary>
    public decimal? EmployeePensionContributionsUnderNpa { get; }

    /// <summary>
    /// Gets the employer's pension contribution in the pay period.
    /// </summary>
    public decimal? EmployePensionContributions { get; }

    /// <summary>
    /// Gets any attachment of earnings deductions made in the pay period.
    /// </summary>
    public decimal AttachmentOfEarningsTotalDeduction { get; }

    /// <summary>
    /// Gets the employee's total gross pay in the pay period.
    /// </summary>
    public decimal TotalGrossPay { get; }

    /// <summary>
    /// Gets the employee's taxable pay in the pay period.
    /// </summary>
    public decimal TaxablePay { get; }

    /// <summary>
    /// Gets the employee's final tax due in the pay period.
    /// </summary>
    public decimal FinalTaxDue { get; }

    /// <summary>
    /// Gets any payrolled benefits in the pay period.
    /// </summary>
    public decimal PayrollBenefitsInPeriod { get; }

    /// <summary>
    /// Gets the employee's NI category used for NI calculations in the pay period.
    /// </summary>
    public NiCategory NiCategory { get; }

    /// <summary>
    /// Gets the employee's NIC-able pay in the pay period.
    /// </summary>
    public decimal NicablePay { get; }

    /// <summary>
    /// Gets the employee NI contribution due in the pay period.
    /// </summary>
    public decimal EmployeeNiContribution { get; }

    /// <summary>
    /// Gets the employer NI contribution due in the pay period.
    /// </summary>
    public decimal EmployerNiContribution { get; }

    /// <summary>
    /// Gets a value indicating whether the payment being made is after the employee has left.
    /// </summary>
    public bool IsPaymentAfterLeaving { get; }

    /// <summary>
    /// Gets the employee student loan type, if applicable.
    /// </summary>
    public StudentLoanType? StudentLoanType { get; }

    /// <summary>
    /// Gets any student loan deduction made in the pay period.
    /// </summary>
    public decimal? StudentLoanDeduction { get; }

    /// <summary>
    /// Gets any postgraduate loan deduction made in the pay period.
    /// </summary>
    public decimal? PostgraduateLoanDeduction { get; }
}