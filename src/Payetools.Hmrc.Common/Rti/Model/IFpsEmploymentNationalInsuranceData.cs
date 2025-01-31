// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the National Insurance data needed to populate the
/// <em>Employment</em> element of the Full Payment Submission message.
/// </summary>
public interface IFpsEmploymentNationalInsuranceData
{
    /// <summary>
    /// Gets the NI category (aka NI letter)for this entry.
    /// </summary>
    NiCategory NiCategory { get; init; }

    /// <summary>
    /// Gets the gross NIC-able earnings in the period.
    /// </summary>
    decimal GrossEarningsForNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the gross NIC-able earnings in the tax year to date.  As per HMRC guidance, this figure
    /// does not include earnings that did not reach the LEL in any earnings period.
    /// </summary>
    decimal GrossEarningsForNICsYtd { get; init; }

    /// <summary>
    /// Gets the earnings at the LEL year to date.
    /// </summary>
    decimal AtLELYtd { get; init; }

    /// <summary>
    /// Gets the earnings above the LEL and up to and including the PT year to date.
    /// </summary>
    decimal LELtoPTYtd { get; init; }

    /// <summary>
    /// Gets the earnings above the PT and up to and including the UEL year to date.
    /// </summary>
    decimal PTtoUELYtd { get; init; }

    /// <summary>
    /// Gets the total employer NI contributions in the period.
    /// </summary>
    decimal TotalEmployerNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the total employer NI contributions year to date.
    /// </summary>
    decimal TotalEmployerNICsYtd { get; init; }

    /// <summary>
    /// Gets the total employee NI contributions in the period.
    /// </summary>
    decimal EmployeeNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the total employee NI contributions year to date.
    /// </summary>
    decimal EmployeeNICsYtd { get; init; }
}
