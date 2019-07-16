// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// POST body schema to query the knowledgebase.
    /// </summary>
    public partial class QueryDTO
    {
        /// <summary>
        /// Initializes a new instance of the QueryDTO class.
        /// </summary>
        public QueryDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryDTO class.
        /// </summary>
        /// <param name="qnaId">Exact qnaId to fetch from the knowledgebase,
        /// this field takes priority over question.</param>
        /// <param name="question">User question to query against the knowledge
        /// base.</param>
        /// <param name="top">Max number of answers to be returned for the
        /// question.</param>
        /// <param name="userId">Unique identifier for the user.</param>
        /// <param name="isTest">Query against the test index.</param>
        /// <param name="scoreThreshold">Threshold for answers returned based
        /// on score.</param>
        /// <param name="context">Context object with previous QnA's
        /// information.</param>
        /// <param name="strictFilters">Find only answers that contain these
        /// metadata.</param>
        public QueryDTO(string qnaId = default(string), string question = default(string), int? top = default(int?), string userId = default(string), bool? isTest = default(bool?), double? scoreThreshold = default(double?), QueryDTOContext context = default(QueryDTOContext), IList<MetadataDTO> strictFilters = default(IList<MetadataDTO>))
        {
            QnaId = qnaId;
            Question = question;
            Top = top;
            UserId = userId;
            IsTest = isTest;
            ScoreThreshold = scoreThreshold;
            Context = context;
            StrictFilters = strictFilters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets exact qnaId to fetch from the knowledgebase, this
        /// field takes priority over question.
        /// </summary>
        [JsonProperty(PropertyName = "qnaId")]
        public string QnaId { get; set; }

        /// <summary>
        /// Gets or sets user question to query against the knowledge base.
        /// </summary>
        [JsonProperty(PropertyName = "question")]
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets max number of answers to be returned for the question.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user.
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets query against the test index.
        /// </summary>
        [JsonProperty(PropertyName = "isTest")]
        public bool? IsTest { get; set; }

        /// <summary>
        /// Gets or sets threshold for answers returned based on score.
        /// </summary>
        [JsonProperty(PropertyName = "scoreThreshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Gets or sets context object with previous QnA's information.
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public QueryDTOContext Context { get; set; }

        /// <summary>
        /// Gets or sets find only answers that contain these metadata.
        /// </summary>
        [JsonProperty(PropertyName = "strictFilters")]
        public IList<MetadataDTO> StrictFilters { get; set; }

    }
}