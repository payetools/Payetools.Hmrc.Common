// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Interface that represents the full set of data needed to make an Employment Payment Summary
/// submission, including header data used to populate elements of the GovTalkMessage header.
/// </summary>
public interface IEmployerPaymentSummary : IRtiSubmissionDocument<IEmployerPaymentSummaryData>
{
}