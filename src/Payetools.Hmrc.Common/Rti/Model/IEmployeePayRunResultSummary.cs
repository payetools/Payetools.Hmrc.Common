// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Hmrc.Common.Rti.Model;

/// <summary>
/// Interface that provides the summary of the employee pay run result, without the
/// calculation details normally provided by the payrun calculation engine.  This
/// interface is more suitable for persisting the results of a pay run.
/// </summary>
public interface IEmployeePayRunResultSummary
{
}