// Copyright (c) 2023-2024 Payetools Foundation.  All rights reserved.
//
// This source code is the intellectual property of Payetools Foundation
// and for information security purposes is classified as CONFIDENTIAL.

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to information needed to populate an RTI document.  More
/// specifically, this interface defines the information needed to populate the IRheader portion of
/// the IRenvelope; specialised interfaces provide access to the data needed for the FPS, EPS
/// and NVR messages.
/// </summary>
public interface IRtiDocumentDataSource
{
    /// <summary>
    /// Gets the relevant period end date.
    /// </summary>
    DateTime PeriodEnd { get; }

    /// <summary>
    /// Gets the optional contact details to be inserted into the IRheader.
    /// </summary>
    IRheaderContact IRheaderContact { get; } // TODO: Implement complete IRheader contact type and mapping

    /// <summary>
    /// Gets the message sender type.
    /// </summary>
    public IRheaderSenderType Sender { get; }

    /// <summary>
    /// Gets the HMRC PAYE reference for this RTI document.
    /// </summary>
    string? HmrcPayeReference { get; }

    /// <summary>
    /// Gets the HMRC accounts office referece for this RTI document.
    /// </summary>
    string? AccountsOfficeReference { get; }
}