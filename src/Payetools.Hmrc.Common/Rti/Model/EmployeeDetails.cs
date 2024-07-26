// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that provides access to the employee's details.
/// </summary>
public class EmployeeDetails : IEmployeeDetails
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
