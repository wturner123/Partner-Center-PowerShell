// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// A billing account resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BillingAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BillingAccount class.
        /// </summary>
        public BillingAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingAccount class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The billing account name.</param>
        /// <param name="address">The address associated with billing
        /// account.</param>
        /// <param name="agreementType">The type of agreement. Possible values
        /// include: 'MicrosoftCustomerAgreement', 'EnterpriseAgreement',
        /// 'MicrosoftOnlineServicesProgram'</param>
        /// <param name="customerType">The type of customer. Possible values
        /// include: 'Enterprise', 'Individual', 'Partner'</param>
        /// <param name="billingProfiles">The billing profiles associated to
        /// the billing account. By default this is not populated, unless it's
        /// specified in $expand.</param>
        /// <param name="enrollmentDetails">The details about the associated
        /// legacy enrollment. By default this is not populated, unless it's
        /// specified in $expand.</param>
        /// <param name="departments">The departments associated to the
        /// enrollment.</param>
        /// <param name="enrollmentAccounts">The accounts associated to the
        /// enrollment.</param>
        /// <param name="organizationId">Organization id.</param>
        public BillingAccount(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), AddressDetails address = default(AddressDetails), string agreementType = default(string), string customerType = default(string), IList<BillingProfile> billingProfiles = default(IList<BillingProfile>), Enrollment enrollmentDetails = default(Enrollment), IList<Department> departments = default(IList<Department>), IList<EnrollmentAccount> enrollmentAccounts = default(IList<EnrollmentAccount>), string organizationId = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Address = address;
            AgreementType = agreementType;
            CustomerType = customerType;
            BillingProfiles = billingProfiles;
            EnrollmentDetails = enrollmentDetails;
            Departments = departments;
            EnrollmentAccounts = enrollmentAccounts;
            OrganizationId = organizationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the billing account name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or sets the address associated with billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.address")]
        public AddressDetails Address { get; set; }

        /// <summary>
        /// Gets the type of agreement. Possible values include:
        /// 'MicrosoftCustomerAgreement', 'EnterpriseAgreement',
        /// 'MicrosoftOnlineServicesProgram'
        /// </summary>
        [JsonProperty(PropertyName = "properties.agreementType")]
        public string AgreementType { get; private set; }

        /// <summary>
        /// Gets the type of customer. Possible values include: 'Enterprise',
        /// 'Individual', 'Partner'
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerType")]
        public string CustomerType { get; private set; }

        /// <summary>
        /// Gets or sets the billing profiles associated to the billing
        /// account. By default this is not populated, unless it's specified in
        /// $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfiles")]
        public IList<BillingProfile> BillingProfiles { get; set; }

        /// <summary>
        /// Gets the details about the associated legacy enrollment. By default
        /// this is not populated, unless it's specified in $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enrollmentDetails")]
        public Enrollment EnrollmentDetails { get; private set; }

        /// <summary>
        /// Gets or sets the departments associated to the enrollment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.departments")]
        public IList<Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the accounts associated to the enrollment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enrollmentAccounts")]
        public IList<EnrollmentAccount> EnrollmentAccounts { get; set; }

        /// <summary>
        /// Gets organization id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.organizationId")]
        public string OrganizationId { get; private set; }

    }
}
