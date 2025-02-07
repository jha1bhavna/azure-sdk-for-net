// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response of the List Event Hubs Clusters operation. </summary>
    internal partial class ClusterListResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClusterListResult"/>. </summary>
        internal ClusterListResult()
        {
            Value = new ChangeTrackingList<EventHubsClusterData>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterListResult"/>. </summary>
        /// <param name="value"> The Event Hubs Clusters present in the List Event Hubs operation results. </param>
        /// <param name="nextLink"> Link to the next set of results. Empty unless the value parameter contains an incomplete list of Event Hubs Clusters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterListResult(IReadOnlyList<EventHubsClusterData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Event Hubs Clusters present in the List Event Hubs operation results. </summary>
        public IReadOnlyList<EventHubsClusterData> Value { get; }
        /// <summary> Link to the next set of results. Empty unless the value parameter contains an incomplete list of Event Hubs Clusters. </summary>
        public string NextLink { get; }
    }
}
