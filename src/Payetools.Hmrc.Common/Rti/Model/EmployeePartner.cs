// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;
using Payetools.Payroll.Model;
using System.Text.Json.Serialization;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Represents an employee's partner details, which are needed for shared parental pay.
/// </summary>
public class EmployeePartner
{
    private NiNumber _niNumber = default!;

    /// <summary>
    /// Gets the partner's National Insurance number.
    /// </summary>
    public string NiNumber { get => _niNumber; init => _niNumber = value; }

    /// <summary>
    /// Gets the partner's name details.
    /// </summary>
    public ContactName Name { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeePartner"/> class. Primarily intended
    /// for serialisation purposes.
    /// </summary>
    /// <param name="niNumber">National insurance number.</param>
    /// <param name="name">Name structure containing the partner's name information.</param>
    [JsonConstructor]
    public EmployeePartner(string niNumber, ContactName name)
    {
        NiNumber = niNumber;
        Name = name;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeePartner"/> type.
    /// </summary>
    /// <param name="niNumber">Partner's NI number.</param>
    /// <param name="forenames">Partner's forename(s).  May be an empty array if initials are supplied.</param>
    /// <param name="initials">Partner's initials.  Ignored if forename(s) are provided.</param>
    /// <param name="surname">Partner's surname.</param>
    public EmployeePartner(NiNumber niNumber, string[] forenames, string? initials, string surname)
    {
        NiNumber = niNumber;

        Name = forenames.Length > 0 ?
            new ContactName(forenames, surname) :
            initials is string inits ?
                new ContactName(inits, surname) :
                throw new InvalidOperationException("Either one or more forenames or a valid set of initials must be supplied");
    }

    /// <summary>
    /// Initialises a new instance of the <see cref="EmployeePartner"/> type.
    /// </summary>
    /// <param name="employeePartnerDetails">Employee partner details.</param>
    public EmployeePartner(IEmployeePartnerDetails employeePartnerDetails)
        : this(
            employeePartnerDetails.NiNumber,
            GetForenames(employeePartnerDetails.NameInfo),
            employeePartnerDetails.NameInfo.InitialsAsString,
            employeePartnerDetails.NameInfo.LastName)
    {
    }

    private static string[] GetForenames(INamedPerson nameInfo)
    {
        if (nameInfo.FirstName == null)
            return [];

        if (!nameInfo.HasMiddleName)
            return new[] { nameInfo.FirstName };

        // This is a little simplistic as some middle names may have two parts separated by space.
        var middleNames = nameInfo.MiddleNames!.Split(' ');
        var forenames = new string[1 + middleNames.Length];

        forenames[0] = nameInfo.FirstName;
        middleNames.CopyTo(forenames, 1);

        return forenames;
    }
}