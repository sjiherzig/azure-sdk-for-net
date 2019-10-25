// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Returns the requested Docker multi-arch-manifest file
    /// </summary>
    public partial class ManifestList : Manifest
    {
        /// <summary>
        /// Initializes a new instance of the ManifestList class.
        /// </summary>
        public ManifestList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManifestList class.
        /// </summary>
        /// <param name="schemaVersion">Schema version</param>
        /// <param name="mediaType">Media type for this Manifest</param>
        /// <param name="manifests">List of V2 image layer information</param>
        public ManifestList(int? schemaVersion = default(int?), string mediaType = default(string), IList<ManifestListAttributes> manifests = default(IList<ManifestListAttributes>))
            : base(schemaVersion)
        {
            MediaType = mediaType;
            Manifests = manifests;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets media type for this Manifest
        /// </summary>
        [JsonProperty(PropertyName = "mediaType")]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or sets list of V2 image layer information
        /// </summary>
        [JsonProperty(PropertyName = "manifests")]
        public IList<ManifestListAttributes> Manifests { get; set; }

    }
}