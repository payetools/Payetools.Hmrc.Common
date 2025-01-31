// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Payroll.Model;

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Entity that represents a UK bank account.
/// </summary>
public class BankAccount : IBankAccount
{
    /// <summary>
    /// Gets the account holder name.
    /// </summary>
    public string AccountName { get; init; }

    /// <summary>
    /// Gets the account number. Should be 8 characters, all numeric, with leading zeroes where
    /// appropriate.
    /// </summary>
    public string AccountNumber { get; init; }

    /// <summary>
    /// Gets the sort code for the account. Should be 6 characters, all numeric, with
    /// leading zeroes where appropriate.
    /// </summary>
    public string SortCode { get; init; }

    /// <summary>
    /// Gets the optional building society reference, where appropriate.
    /// </summary>
    public string? BuildingSocietyReference { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BankAccount"/> class.
    /// </summary>
    /// <param name="accountName">Bank account holder name.</param>
    /// <param name="accountNumber">Bank account number. Should be 8 characters, all numeric, with leading zeroes
    /// where appropriate.</param>
    /// <param name="sortCode">Bank sort code for the account. Should be 6 characters, all numeric, with
    /// leading zeroes where appropriate.</param>
    /// <param name="buildingSocietyReference">Optional building society reference, where appropriate.</param>
    public BankAccount(string? accountName, string? accountNumber, string? sortCode, string? buildingSocietyReference = null)
    {
        AccountName = accountName ?? string.Empty;
        AccountNumber = accountNumber ?? string.Empty;
        SortCode = sortCode ?? string.Empty;
        BuildingSocietyReference = buildingSocietyReference;
    }
}