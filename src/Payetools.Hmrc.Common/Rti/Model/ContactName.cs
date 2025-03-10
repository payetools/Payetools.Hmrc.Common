// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using System.Text;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Represents the name portion of a contact.
/// </summary>
public class ContactName
{
    /// <summary>
    /// Gets the contact title.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// Gets the contact forename. May contain 0, 1 or 2 names.  If no names are supplied, this
    /// field should be set to an empty array and the Initials property set accordingly.  Note that
    /// the Initials property is NOT supported for Agent and Principal names in the IRenvelope.
    /// </summary>
    public string[] Forenames { get; init; } = default!;

    /// <summary>
    /// Gets the initials, if appropriate.  Not supported within the Agent and Principal elements of
    /// the IRenvelope element.
    /// </summary>
    public string? Initials { get; init; }

    /// <summary>
    /// Gets the contact surname.
    /// </summary>
    public string Surname { get; init; } = default!;

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactName"/> class with empty title. Primarily
    /// intended for serialisation purposes.
    /// </summary>
    public ContactName()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactName"/> class with empty title.
    /// </summary>
    /// <param name="forenames">Contact forename.</param>
    /// <param name="surname">Contact surname.</param>
    public ContactName(string[] forenames, string surname)
        : this(string.Empty, forenames, surname)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactName"/> class with empty title, using
    /// initials rather than forename(s).
    /// </summary>
    /// <param name="initials">Contact initials.</param>
    /// <param name="surname">Contact surname.</param>
    public ContactName(string initials, string surname)
        : this(string.Empty, initials, surname)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactName"/> class.
    /// </summary>
    /// <param name="title">Contact title (.e.g., Mr, Ms).</param>
    /// <param name="forenames">Contact forename.</param>
    /// <param name="surname">Contact surname.</param>
    public ContactName(string? title, string[] forenames, string surname)
    {
        if (title != null)
            Title = title;

        Forenames = forenames;
        Surname = surname;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactName"/> class, using
    /// initials rather than forename(s).
    /// </summary>
    /// <param name="title">Contact title (.e.g., Mr, Ms).</param>
    /// <param name="initials">Contact initials.</param>
    /// <param name="surname">Contact surname.</param>
    public ContactName(string? title, string initials, string surname)
    {
        if (title != null)
            Title = title;

        Forenames = Array.Empty<string>();
        Initials = initials;
        Surname = surname;
    }

    /// <summary>
    /// Gets an empty <see cref="ContactName"/>.
    /// </summary>
    public static ContactName Empty =>
        new ContactName(string.Empty, string.Empty, string.Empty);

    /// <summary>
    /// Returns this contact name as a human-readable string.
    /// </summary>
    /// <returns>Contact name as human-readable string.</returns>
    public override string ToString() => ToString(false);

    /// <summary>
    /// Returns this contact name as a human-readable string.
    /// </summary>
    /// <param name="includeTitle">Set to true to include the individual's title.</param>
    /// <returns>Contact name as human-readable string.</returns>
    public string ToString(bool includeTitle)
    {
        var sb = new StringBuilder();

        if (includeTitle && !string.IsNullOrWhiteSpace(Title))
            sb.Append(Title).Append(' ');

        if (Forenames != null && Forenames.Length > 0)
            sb.Append(string.Join(' ', Forenames));

        if (!string.IsNullOrWhiteSpace(Initials))
            sb.Append(Initials).Append(' ');

        sb.Append(Surname);

        return sb.ToString();
    }
}