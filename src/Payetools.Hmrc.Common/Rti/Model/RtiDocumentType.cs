// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// RTI document type enumeration.
/// </summary>
public enum RtiDocumentType
{
    /// <summary>Employer Payment Summary (EPS).</summary>
    EmployerPaymentSummary = 0,

    /// <summary>Full Payment Submission (FPS).</summary>
    FullPaymentSubmission = 1,

    /// <summary>NINO Verification Request (NVR).</summary>
    NinoVerificationRequest = 2
}