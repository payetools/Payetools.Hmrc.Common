// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that contains the data set needed to populate a NINO Verification Request.
/// </summary>
public class NinoVerificationRequestData : IRenvelopeData, INinoVerificationRequestData
{
    /// <summary>
    /// Gets the employee entries, one for each employee being queried within the NVR.
    /// </summary>
    public INinoVerificationRequestEmployeeEntry[] EmployeeEntries { get; init; } = default!;
}
