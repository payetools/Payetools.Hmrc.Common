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
    /// Gets or sets the employee's National Insurance number.
    /// </summary>
    public string NiNumber { get; set; } = default!;

    /// <summary>
    /// Gets or sets the employee's name details.
    /// </summary>
    public ContactName Name { get; set; } = default!;

    /// <summary>
    /// Gets or sets the employee's postal address.
    /// </summary>
    public Address Address { get; set; } = default!;

    /// <summary>
    /// Gets or sets the employee's date of birth.
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the employee's gender.
    /// </summary>
    public Gender Gender { get; set; }

    /// <summary>
    /// Gets or sets the employee's passport number. Optional.
    /// </summary>
    public string? PassportNumber { get; set; }

    /// <summary>
    /// Gets or sets the employee's partner's details. Optional.
    /// </summary>
    public EmployeePartner? PartnerDetails { get; set; }
}
