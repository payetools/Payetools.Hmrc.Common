// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the data set needed to populate a NINO Verification Request.
/// </summary>
public interface INinoVerificationRequestEmployeeEntry
{
    /// <summary>
    /// Gets the name of the individual that this NVR relates to.
    /// </summary>
    ContactName Name { get; }

    /// <summary>
    /// Gets the date of birth of the individual that this NVR relates to.
    /// </summary>
    DateOnly DateOfBirth { get; }

    /// <summary>
    /// Gets the postal address of the individual that this NVR relates to.
    /// </summary>
    PostalAddress PostalAddress { get; }

    /// <summary>
    /// Gets the National Insurance number of the individual that this NVR relates to,
    /// if known. Null otherwise.
    /// </summary>
    NiNumber? NiNumber { get; }

    /// <summary>
    /// Gets the gender of the individual that this NVR relates to.
    /// </summary>
    Gender Gender { get; }

    /// <summary>
    /// Gets the payroll ID of the individual that this NVR relates to.
    /// </summary>
    PayrollId PayrollId { get; }
}
