// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Enumeration that defines the types of sender within the IRenvelope of the GovTalkMessage.
/// </summary>
/// <remarks>For PAYE submissions the most appropriate entries are Agent, Bureau or Employer.</remarks>
public enum IRheaderSenderType
{
    /// <summary>Individual</summary>
    Individual,

    /// <summary>Company</summary>
    Company,

    /// <summary>Agent</summary>
    Agent,

    /// <summary>Bureau</summary>
    Bureau,

    /// <summary>Partnership</summary>
    Partnership,

    /// <summary>Trust</summary>
    Trust,

    /// <summary>Employer</summary>
    Employer,

    /// <summary>Government</summary>
    Government,

    /// <summary>ActingInCapacity</summary>
    ActingInCapacity,

    /// <summary>Other</summary>
    Other
}

/// <summary>
/// Extension methods for <see cref="IRheaderSenderType"/>.
/// </summary>
public static class IRheaderSenderExtensions
{
    /// <summary>
    /// Gets the string representation of a <see cref="IRheaderSenderType"/>.
    /// </summary>
    /// <param name="sender">IRheader sender.</param>
    /// <returns>RTI-friendly sender value.</returns>
    public static string ToSender(this IRheaderSenderType sender) =>
        sender switch
        {
            IRheaderSenderType.ActingInCapacity => "Acting in Capacity",
            _ => sender.ToString()
        };
}
