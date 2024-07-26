// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that provides access to the set of year-to-date recoverable amounts data needed
/// to populate an Employer Payment Summary.
/// </summary>
public class RecoverableAmountsYtd : IRecoverableAmountsYtd
{
    /// <summary>
    /// Gets the tax month for this set of recoverable amounts.
    /// </summary>
    public string TaxMonth { get; init; } = default!;

    /// <summary>
    /// Gets the Statutory Maternity Pay amount recovered, if appropriate. Null otherwise.
    /// </summary>
    public decimal SMPRecovered { get; init; }

    /// <summary>
    /// Gets the Statutory Paternity Pay amount recovered, if appropriate. Null otherwise.
    /// </summary>
    public decimal SPPRecovered { get; init; }

    /// <summary>
    /// Gets the Statutory Adoption Pay amount recovered, if appropriate. Null otherwise.
    /// </summary>
    public decimal SAPRecovered { get; init; }

    /// <summary>
    /// Gets the Statutory Shared Parental Pay amount recovered, if appropriate. Null otherwise.
    /// </summary>
    public decimal ShPPRecovered { get; init; }

    /// <summary>
    /// Gets the Statutory Parental Bereavement Pay amount recovered, if appropriate. Null otherwise.
    /// </summary>
    public decimal SPBPRecovered { get; init; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SMP
    /// recovered year to date.
    /// </summary>
    public decimal NICCompensationOnSMP { get; init; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SPP
    /// recovered year to date.
    /// </summary>
    public decimal NICCompensationOnSPP { get; init; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SAP
    /// recovered year to date.
    /// </summary>
    public decimal NICCompensationOnSAP { get; init; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the ShPP
    /// recovered year to date.
    /// </summary>
    public decimal NICCompensationOnShPP { get; init; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SPBP
    /// recovered year to date.
    /// </summary>
    public decimal NICCompensationOnSPBP { get; init; }

    /// <summary>
    /// Gets the the full amount of CIS deductions taken from the company's payments in the year to date.
    /// </summary>
    public decimal CISDeductionsSuffered { get; init; }

    /// <summary>
    /// Gets a value indicating whether all the decimal values of this type are zero, i.e., there is no
    /// information in this <see cref="IRecoverableAmountsYtd"/> instance.
    /// </summary>
    public bool AreAllValuesZero =>
        (SMPRecovered +
         SPPRecovered +
         SAPRecovered +
         ShPPRecovered +
         SPBPRecovered +
         NICCompensationOnSMP +
         NICCompensationOnSPP +
         NICCompensationOnSAP +
         NICCompensationOnShPP +
         NICCompensationOnSPBP +
         CISDeductionsSuffered) == 0m;
}