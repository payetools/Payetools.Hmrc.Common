// Copyright (c) 2023-2024 Payetools Foundation.  All rights reserved.
//
// This source code is the intellectual property of Payetools Foundation
// and for information security purposes is classified as CONFIDENTIAL.

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Rti.Model.Population;

/// <summary>
/// Entity that contains  the data set needed to populate a NINO Verfication Request.
/// </summary>
public interface INinoVerificationRequestData : IRtiDocumentDataSource
{
    /// <summary>
    /// Gets the employee entries, one for each employee being queried within the NVR.
    /// </summary>
    public INinoVerificationRequestEmployeeEntry[] EmployeeEntries { get; }
}