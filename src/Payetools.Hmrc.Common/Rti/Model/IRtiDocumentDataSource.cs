// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

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
    DateTime PeriodEnd { get; init; }

    /// <summary>
    /// Gets the optional contact details to be inserted into the IRheader.
    /// </summary>
    IRheaderContact IRheaderContact { get; init; } // TODO: Implement complete IRheader contact type and mapping

    /// <summary>
    /// Gets the message sender type.
    /// </summary>
    public IRheaderSenderType Sender { get; init; }

    /// <summary>
    /// Gets the HMRC PAYE reference for this RTI document.
    /// </summary>
    string? HmrcPayeReference { get; init; }

    /// <summary>
    /// Gets the HMRC accounts office reference for this RTI document.
    /// </summary>
    string? AccountsOfficeReference { get; init; }
}