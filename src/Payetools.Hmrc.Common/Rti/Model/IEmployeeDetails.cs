// Copyright (c) 2023-2024, Payetools Foundation.
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
    /// Gets the employee's National Insurance number.
    /// </summary>
    string NiNumber { get; init; }

    /// <summary>
    /// Gets the employee's name details.
    /// </summary>
    ContactName Name { get; init; }

    /// <summary>
    /// Gets the employee's postal address.
    /// </summary>
    Address Address { get; init; }

    /// <summary>
    /// Gets the employee's date of birth.
    /// </summary>
    DateTime DateOfBirth { get; init; }

    /// <summary>
    /// Gets the employee's gender.
    /// </summary>
    Gender Gender { get; init; }

    /// <summary>
    /// Gets the employee's passport number.  Optional.
    /// </summary>
    string? PassportNumber { get; init; }

    /// <summary>
    /// Gets the employee's partner's details.  Optional.
    /// </summary>
    EmployeePartner? PartnerDetails { get; init; }
}
