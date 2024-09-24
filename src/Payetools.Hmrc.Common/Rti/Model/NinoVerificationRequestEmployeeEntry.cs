// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that contains the data set needed to populate a NINO Verfication Request.
/// </summary>
public class NinoVerificationRequestEmployeeEntry : INinoVerificationRequestEmployeeEntry
{
    /// <summary>
    /// Gets the name of the individual that this NVR relates to.
    /// </summary>
    public ContactName Name { get; init; } = default!;

    /// <summary>
    /// Gets the date of birth of the individual that this NVR relates to.
    /// </summary>
    public DateOnly DateOfBirth { get; init; }

    /// <summary>
    /// Gets the postal address of the individual that this NVR relates to.
    /// </summary>
    public PostalAddress PostalAddress { get; init; } = default!;

    /// <summary>
    /// Gets the National Insurance number of the individual that this NVR relates to,
    /// if known. Null otherwise.
    /// </summary>
    public NiNumber? NiNumber { get; init; }

    /// <summary>
    /// Gets the gender of the individual that this NVR relates to.
    /// </summary>
    public Gender Gender { get; init; }

    /// <summary>
    /// Gets the payroll ID of the individual that this NVR relates to.
    /// </summary>
    public PayrollId PayrollId { get; init; } = default!;
}
