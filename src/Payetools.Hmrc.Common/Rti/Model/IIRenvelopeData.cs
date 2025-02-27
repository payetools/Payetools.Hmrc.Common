// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that represents the data set needed to populate the header elements
/// of the IRenvelope.
/// </summary>
public interface IIRenvelopeData
{
    /// <summary>
    /// Gets the period end date for the data within the contained FPS/EPS/NVR message.
    /// </summary>
    DateTime PeriodEnd { get; init; }

    /// <summary>
    /// Gets optional header contact details.  If no header contact details are provided, then the
    /// <see cref="IRheaderContact.ContactType"/> property must be set to None.
    /// </summary>
    IRheaderContact IRheaderContact { get; init; }

    /// <summary>
    /// Gets the message sender type.
    /// </summary>
    IRheaderSenderType Sender { get; init; }

    /// <summary>
    /// Gets the HMRC accounts office reference.
    /// </summary>
    string? AccountsOfficeReference { get; init; }

    /// <summary>
    /// Gets the HMRC PAYE reference.
    /// </summary>
    string? HmrcPayeReference { get; init; }
}