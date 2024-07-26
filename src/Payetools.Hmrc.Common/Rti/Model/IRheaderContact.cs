// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Represents (optional) contact information that is inserted into the IRheader.
/// </summary>
public class IRheaderContact
{
    /// <summary>
    /// Gets the type of this contact (none vs principal vs agent).
    /// </summary>
    public IRheaderContactType ContactType { get; init; }

    /// <summary>
    /// Gets the name of the contact.
    /// </summary>
    public ContactName Name { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="IRheaderContact"/> class.
    /// </summary>
    /// <param name="contactType">Contact type (agent vs principal, or none).</param>
    /// <param name="name">Contact name information.</param>
    public IRheaderContact(IRheaderContactType contactType, ContactName name)
    {
        ContactType = contactType;
        Name = name;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IRheaderContact"/> class with empty contact
    /// name details.
    /// </summary>
    public IRheaderContact()
    {
        ContactType = IRheaderContactType.None;
        Name = ContactName.Empty;
    }
}