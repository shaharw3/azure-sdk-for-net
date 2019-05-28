// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents settings associated with a project.
    /// </summary>
    public partial class ProjectSettings
    {
        /// <summary>
        /// Initializes a new instance of the ProjectSettings class.
        /// </summary>
        public ProjectSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProjectSettings class.
        /// </summary>
        /// <param name="domainId">Gets or sets the id of the Domain to use
        /// with this project.</param>
        /// <param name="classificationType">Gets or sets the classification
        /// type of the project. Possible values include: 'Multiclass',
        /// 'Multilabel'</param>
        /// <param name="targetExportPlatforms">A list of ExportPlatform that
        /// the trained model should be able to support.</param>
        public ProjectSettings(System.Guid domainId = default(System.Guid), string classificationType = default(string), IList<string> targetExportPlatforms = default(IList<string>))
        {
            DomainId = domainId;
            ClassificationType = classificationType;
            TargetExportPlatforms = targetExportPlatforms;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the Domain to use with this project.
        /// </summary>
        [JsonProperty(PropertyName = "domainId")]
        public System.Guid DomainId { get; set; }

        /// <summary>
        /// Gets or sets the classification type of the project. Possible
        /// values include: 'Multiclass', 'Multilabel'
        /// </summary>
        [JsonProperty(PropertyName = "classificationType")]
        public string ClassificationType { get; set; }

        /// <summary>
        /// Gets or sets a list of ExportPlatform that the trained model should
        /// be able to support.
        /// </summary>
        [JsonProperty(PropertyName = "targetExportPlatforms")]
        public IList<string> TargetExportPlatforms { get; set; }

    }
}