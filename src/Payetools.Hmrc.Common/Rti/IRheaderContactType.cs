// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Enum that indicates which type of contact an <see cref="IRheaderContact"/> contains.  The
/// <em>None</em> value indicates the IRheaderContact is not used.
/// </summary>
public enum IRheaderContactType
{
    /// <summary>Empty contact type, indicating the entity is unused.</summary>
    None,

    /// <summary>Indicates the contact is a <em>principal</em> contact.</summary>
    Principal,

    /// <summary>Indicates the contact is an <em>agent</em> contact.</summary>
    Agent
}