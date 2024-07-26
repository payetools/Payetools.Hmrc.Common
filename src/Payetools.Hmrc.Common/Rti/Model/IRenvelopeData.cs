// Copyright (c) 2023-2024 Payetools Foundation.  All rights reserved.
//
// This source code is the intellectual property of Payetools Foundation
// and for information security purposes is classified as CONFIDENTIAL.

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Represents the data set needed to populate the header elements of the IRenvelope.
/// </summary>
public class IRenvelopeData : IRtiDocumentDataSource
{
    /// <summary>
    /// Gets the period end date for the data within the contained FPS/EPS/NVR message.
    /// </summary>
    public DateTime PeriodEnd { get; }

    /// <summary>
    /// Gets optional header contact details.  If no header contact details are provided, then the
    /// <see cref="IRheaderContact.ContactType"/> property must be set to None.
    /// </summary>
    public IRheaderContact IRheaderContact { get; }

    /// <summary>
    /// Gets the message sender type.
    /// </summary>
    public IRheaderSenderType Sender { get; }

    /// <summary>
    /// Gets the HMRC accounts office reference.
    /// </summary>
    public string? AccountsOfficeReference { get; }

    /// <summary>
    /// Gets the HMRC PAYE reference.
    /// </summary>
    public string? HmrcPayeReference { get; }

    /// <summary>
    /// Initializes a new instance of a <see cref="IRenvelopeData"/> with the supplied parameters.
    /// </summary>
    /// <param name="periodEnd">Period end date for the data within the contained FPS/EPS/NVR message.</param>
    /// <param name="iRheaderContact">Optional header contact details.  Must be supplied but contact details
    /// may be omitted by setting the <see cref="IRheaderContact.ContactType"/> property to None.</param>
    /// <param name="sender">Message sender type.</param>
    /// <param name="hmrcPayeReference">HMRC PAYE reference.  May be null.</param>
    /// <param name="accountsOfficeReference">HMRC accounts office reference.  May be null.</param>
    public IRenvelopeData(
        in DateTime periodEnd,
        in IRheaderContact iRheaderContact,
        in IRheaderSenderType sender,
        in string? hmrcPayeReference,
        in string? accountsOfficeReference)
    {
        PeriodEnd = periodEnd;
        IRheaderContact = iRheaderContact;
        Sender = sender;
        AccountsOfficeReference = accountsOfficeReference;
        HmrcPayeReference = hmrcPayeReference;
    }

    /// <summary>
    /// Initializes a new instance of a <see cref="IRenvelopeData"/> with the supplied envelope data.
    /// </summary>
    /// <param name="data">Envelope data to copy.</param>
    protected IRenvelopeData(in IRenvelopeData data)
    {
        PeriodEnd = data.PeriodEnd;
        IRheaderContact = data.IRheaderContact;
        Sender = data.Sender;
        AccountsOfficeReference = data.AccountsOfficeReference;
        HmrcPayeReference = data.HmrcPayeReference;
    }
}
