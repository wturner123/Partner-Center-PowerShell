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
    using Newtonsoft.Json;

    /// <summary>
    /// Defines headers for CreateSubscription operation.
    /// </summary>
    public partial class SubscriptionFactoryCreateSubscriptionHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionFactoryCreateSubscriptionHeaders class.
        /// </summary>
        public SubscriptionFactoryCreateSubscriptionHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionFactoryCreateSubscriptionHeaders class.
        /// </summary>
        /// <param name="location">GET this URL to retrieve the status of the
        /// asynchronous operation.</param>
        /// <param name="retryAfter">The amount of delay to use while the
        /// status of the operation is checked. The value is expressed in
        /// seconds.</param>
        public SubscriptionFactoryCreateSubscriptionHeaders(string location = default(string), int? retryAfter = default(int?))
        {
            Location = location;
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets GET this URL to retrieve the status of the
        /// asynchronous operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the amount of delay to use while the status of the
        /// operation is checked. The value is expressed in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}
