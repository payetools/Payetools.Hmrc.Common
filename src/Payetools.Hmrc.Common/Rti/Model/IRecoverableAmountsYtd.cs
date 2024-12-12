// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides access to the set of year-to-date recoverable amounts data needed
/// to populate an Employer Payment Summary.
/// </summary>
public interface IRecoverableAmountsYtd
{
    /// <summary>
    /// Gets the tax month for this set of recoverable amounts.
    /// </summary>
    string TaxMonth { get; }

    /// <summary>
    /// Gets the Statutory Maternity Pay amount recovered, if appropriate. Zero otherwise.
    /// </summary>
    decimal SMPRecovered { get; }

    /// <summary>
    /// Gets the Statutory Paternity Pay amount recovered, if appropriate. Zero otherwise.
    /// </summary>
    decimal SPPRecovered { get; }

    /// <summary>
    /// Gets the Statutory Adoption Pay amount recovered, if appropriate. Zero otherwise.
    /// </summary>
    decimal SAPRecovered { get; }

    /// <summary>
    /// Gets the Statutory Shared Parental Pay amount recovered, if appropriate. Zero otherwise.
    /// </summary>
    decimal ShPPRecovered { get; }

    /// <summary>
    /// Gets the Statutory Parental Bereavement Pay amount recovered, if appropriate. Zero otherwise.
    /// </summary>
    decimal SPBPRecovered { get; }

    /// <summary>
    /// Gets the Statutory Neonatal Care Pay amount recovered, if appropriate. Zero otherwise.
    /// </summary>
    /// <remarks>Only applicable from April 2025.</remarks>
    decimal SNCPRecovered { get; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SMP
    /// recovered year to date.
    /// </summary>
    decimal NICCompensationOnSMP { get; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SPP
    /// recovered year to date.
    /// </summary>
    decimal NICCompensationOnSPP { get; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SAP
    /// recovered year to date.
    /// </summary>
    decimal NICCompensationOnSAP { get; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the ShPP
    /// recovered year to date.
    /// </summary>
    decimal NICCompensationOnShPP { get; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SPBP
    /// recovered year to date.
    /// </summary>
    decimal NICCompensationOnSPBP { get; }

    /// <summary>
    /// Gets the value of any compensation the employer is entitled to claim in addition to the SNCP
    /// recovered year to date.
    /// </summary>
    /// <remarks>Only applicable from April 2025.</remarks>
    decimal NICCompensationOnSNCP { get; }

    /// <summary>
    /// Gets the the full amount of CIS deductions taken from the company's payments in the year to date.
    /// </summary>
    decimal CISDeductionsSuffered { get; }

    /// <summary>
    /// Gets a value indicating whether all the decimal values of this type are zero, i.e., there is no
    /// information in this <see cref="IRecoverableAmountsYtd"/> instance.
    /// </summary>
    bool AreAllValuesZero { get; }
}