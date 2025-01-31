// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.Hmrc.Common.Rti.Model;

namespace Payetools.Hmrc.Common.Rti;

/// <summary>
/// Interface that represents a generic submission document.
/// </summary>
/// <typeparam name="T">Type of data document for submission.</typeparam>
public interface IRtiSubmissionDocument<T> where T : class, IRtiDocumentDataSource
{
    /// <summary>
    /// Gets the header data elements such as submission credentials and test mode indicator.
    /// </summary>
    ISubmissionHeader Header { get; init; }

    /// <summary>
    /// Gets the submission content.
    /// </summary>
    T Submission { get; init; }
}
