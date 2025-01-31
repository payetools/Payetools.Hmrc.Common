// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Common.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Represents the National Insurance record portion of an employment entry in the FPS.
/// </summary>
public class FpsEmploymentNiData : IFpsEmploymentNationalInsuranceData
{
    /// <summary>
    /// Gets the NI category (aka NI letter)for this entry.
    /// </summary>
    public NiCategory NiCategory { get; init; }

    /// <summary>
    /// Gets the gross NIC-able earnings in the period.
    /// </summary>
    public decimal GrossEarningsForNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the gross NIC-able earnings in the tax year to date.  As per HMRC guidance, this figure
    /// does not include earnings that did not reach the LEL in any earnings period.
    /// </summary>
    public decimal GrossEarningsForNICsYtd { get; init; }

    /// <summary>
    /// Gets the earnings at the LEL year to date.
    /// </summary>
    public decimal AtLELYtd { get; init; }

    /// <summary>
    /// Gets the earnings above the LEL and up to and including the PT year to date.
    /// </summary>
    public decimal LELtoPTYtd { get; init; }

    /// <summary>
    /// Gets the earnings above the PT and up to and including the UEL year to date.
    /// </summary>
    public decimal PTtoUELYtd { get; init; }

    /// <summary>
    /// Gets the total employer NI contributions in the period.
    /// </summary>
    public decimal TotalEmployerNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the total employer NI contributions year to date.
    /// </summary>
    public decimal TotalEmployerNICsYtd { get; init; }

    /// <summary>
    /// Gets the total employee NI contributions in the period.
    /// </summary>
    public decimal EmployeeNICsInPeriod { get; init; }

    /// <summary>
    /// Gets the total employee NI contributions year to date.
    /// </summary>
    public decimal EmployeeNICsYtd { get; init; }
}
