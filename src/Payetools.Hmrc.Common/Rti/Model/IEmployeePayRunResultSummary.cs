// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

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
    public decimal EmployeePensionContributionsOutsideNpa { get; }

    /// <summary>
    /// Gets any attachment of earnings deductions made in the pay period.
    /// </summary>
    public decimal AttachmentOfEarningsTotalDeduction { get; }

    /// <summary>
    /// Gets the employee's total gross pay in the pay period.
    /// </summary>
    public decimal TotalGrossPay { get; }

    /// <summary>
    /// Gets any payrolled benefits in the pay period.
    /// </summary>
    public decimal PayrollBenefitsInPeriod { get; }

    /// <summary>
    /// Gets the employee's final tax due in the pay period.
    /// </summary>
    public decimal FinalTaxDue { get; }

    /// <summary>
    /// Gets the employee's final NI contribution due in the pay period.
    /// </summary>
    public decimal EmployeeNiContribution { get; }

    /// <summary>
    /// Gets any student loan (including postgrad loans) deductions made in the pay period.
    /// </summary>
    public decimal StudentLoanTotalDeduction { get; }
}