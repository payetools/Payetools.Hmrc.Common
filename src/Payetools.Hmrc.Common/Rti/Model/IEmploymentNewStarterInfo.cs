// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Payroll.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to an employee's new starter information, where appropriate.
/// </summary>
public interface IEmploymentNewStarterInfo
{
    /// <summary>
    /// Gets the start date for the employee.
    /// </summary>
    DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// Gets the starter declaration, A, B or C.
    /// </summary>
    StarterDeclaration Declaration { get; init; }

    /// <summary>
    /// Gets a value indicating whether student loans should continue in the new employment.
    /// </summary>
    bool? StudentLoanPaymentsToContinue { get; init; }

    /// <summary>
    /// Gets a value indicating whether postgraduate loans should continue in the new employment.
    /// </summary>
    bool? PostgraduateLoanToContinue { get; init; }

    // TODO: Implement SecondmentInfo
    // TODO: Implement OccupationalPensionPayment

    // Note: The StatePension element is only used by DWP, so is not included here.
}
