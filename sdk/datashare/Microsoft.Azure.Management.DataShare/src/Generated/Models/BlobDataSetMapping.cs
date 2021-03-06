// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Blob data set mapping.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Blob")]
    [Rest.Serialization.JsonTransformation]
    public partial class BlobDataSetMapping : DataSetMapping
    {
        /// <summary>
        /// Initializes a new instance of the BlobDataSetMapping class.
        /// </summary>
        public BlobDataSetMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobDataSetMapping class.
        /// </summary>
        /// <param name="containerName">Container that has the file
        /// path.</param>
        /// <param name="dataSetId">The id of the source data set.</param>
        /// <param name="filePath">File path within the source data set</param>
        /// <param name="resourceGroup">Resource group of storage
        /// account.</param>
        /// <param name="storageAccountName">Storage account name of the source
        /// data set.</param>
        /// <param name="subscriptionId">Subscription id of storage
        /// account.</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetMappingStatus">Gets the status of the data set
        /// mapping. Possible values include: 'Ok', 'Broken'</param>
        /// <param name="outputType">File output type. Possible values include:
        /// 'Csv', 'Parquet'</param>
        /// <param name="provisioningState">Provisioning state of the data set
        /// mapping. Possible values include: 'Succeeded', 'Creating',
        /// 'Deleting', 'Moving', 'Failed'</param>
        public BlobDataSetMapping(string containerName, string dataSetId, string filePath, string resourceGroup, string storageAccountName, string subscriptionId, string id = default(string), string name = default(string), string type = default(string), string dataSetMappingStatus = default(string), string outputType = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            ContainerName = containerName;
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            FilePath = filePath;
            OutputType = outputType;
            ProvisioningState = provisioningState;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets container that has the file path.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the id of the source data set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; set; }

        /// <summary>
        /// Gets the status of the data set mapping. Possible values include:
        /// 'Ok', 'Broken'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetMappingStatus")]
        public string DataSetMappingStatus { get; private set; }

        /// <summary>
        /// Gets or sets file path within the source data set
        /// </summary>
        [JsonProperty(PropertyName = "properties.filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets file output type. Possible values include: 'Csv',
        /// 'Parquet'
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputType")]
        public string OutputType { get; set; }

        /// <summary>
        /// Gets provisioning state of the data set mapping. Possible values
        /// include: 'Succeeded', 'Creating', 'Deleting', 'Moving', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets resource group of storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets storage account name of the source data set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountName")]
        public string StorageAccountName { get; set; }

        /// <summary>
        /// Gets or sets subscription id of storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContainerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContainerName");
            }
            if (DataSetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSetId");
            }
            if (FilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FilePath");
            }
            if (ResourceGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceGroup");
            }
            if (StorageAccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountName");
            }
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubscriptionId");
            }
        }
    }
}
