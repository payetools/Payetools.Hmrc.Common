// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

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
