// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the employee's details.
/// </summary>
public interface IEmployeeDetails
{
    /// <summary>
    /// Gets or sets the employee's National Insurance number.
    /// </summary>
    string NiNumber { get; set; }

    /// <summary>
    /// Gets or sets the employee's name details.
    /// </summary>
    ContactName Name { get; set; }

    /// <summary>
    /// Gets or sets the employee's postal address.
    /// </summary>
    Address Address { get; set; }

    /// <summary>
    /// Gets or sets the employee's date of birth.
    /// </summary>
    DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the employee's gender.
    /// </summary>
    Gender Gender { get; set; }

    /// <summary>
    /// Gets or sets the employee's passport number.  Optional.
    /// </summary>
    string? PassportNumber { get; set; }

    /// <summary>
    /// Gets or sets the employee's partner's details.  Optional.
    /// </summary>
    EmployeePartner? PartnerDetails { get; set; }
}
