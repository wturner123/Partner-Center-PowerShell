// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.Subscription.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Result of the request to list operations. It contains a list of
    /// operations and a URL link to get the next set of results.
    /// </summary>
    public partial class OperationListResult
    {
        /// <summary>
        /// Initializes a new instance of the OperationListResult class.
        /// </summary>
        public OperationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationListResult class.
        /// </summary>
        /// <param name="value">List of operations.</param>
        /// <param name="nextLink">URL to get the next set of operation list
        /// results if there are any.</param>
        public OperationListResult(IList<Operation> value = default(IList<Operation>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of operations.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Operation> Value { get; set; }

        /// <summary>
        /// Gets or sets URL to get the next set of operation list results if
        /// there are any.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
