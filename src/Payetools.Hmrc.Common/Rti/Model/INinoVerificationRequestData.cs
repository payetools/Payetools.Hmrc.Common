// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the data set needed to populate a NINO Verification Request.
/// </summary>
public interface INinoVerificationRequestData : IRtiDocumentDataSource
{
    /// <summary>
    /// Gets the employee entries, one for each employee being queried within the NVR.
    /// </summary>
    public INinoVerificationRequestEmployeeEntry[] EmployeeEntries { get; }
}