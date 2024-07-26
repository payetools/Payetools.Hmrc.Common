// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the employee's employment details, including payments made in
/// the current period.
/// </summary>
public interface IFullPaymentSubmissionEmployeeEntry
{
    /// <summary>
    /// Gets the employee's details.
    /// </summary>
    IEmployeeDetails EmployeeDetails { get; init; }

    /// <summary>
    /// Gets the employee's employment details, including payments made in the current period.
    /// </summary>
    IEmploymentData[] EmploymentDetails { get; init; }
}
