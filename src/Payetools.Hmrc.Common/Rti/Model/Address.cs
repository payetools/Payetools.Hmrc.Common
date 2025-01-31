// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Represents a postal address.  If it is a UK address, <see cref="Postcode"/> should be supplied
/// and <see cref="ForeignCountry"/> set to null or omitted; if the address is non-UK, then Postcode should
/// be null and ForeignCountry should be provided.
/// </summary>
public class Address
{
    /// <summary>Gets the first line of the address.</summary>
    public string AddressLine1 { get; init; } = default!;

    /// <summary>Gets the second line of the address.</summary>
    public string AddressLine2 { get; init; } = default!;

    /// <summary>Gets the third line of the address. Optional.</summary>
    public string? AddressLine3 { get; init; }

    /// <summary>Gets the fourth line of the address. Optional.</summary>
    public string? AddressLine4 { get; init; }

    /// <summary>Gets the postcode (UK addresses only).</summary>
    public string? Postcode { get; init; }

    /// <summary>Gets the foreign country (non-UK addresses only).</summary>
    public string? ForeignCountry { get; init; }

    /// <summary>
    /// Creates a new <see cref="Address"/> object from the supplied <see cref="PostalAddress"/>
    /// instance.
    /// </summary>
    /// <param name="postalAddress"><see cref="PostalAddress"/> instance.</param>
    /// <returns>New <see cref="Address"/> instance populated from the supplied PostalAddress.</returns>
    public static Address FromPostalAddress(in PostalAddress postalAddress) =>
        new Address
        {
            AddressLine1 = postalAddress.AddressLine1,
            AddressLine2 = postalAddress.AddressLine2,
            AddressLine3 = postalAddress.AddressLine3,
            AddressLine4 = postalAddress.AddressLine4,
            Postcode = postalAddress.Postcode != null ? (string)postalAddress.Postcode : null,
            ForeignCountry = postalAddress.ForeignCountry
        };
}
