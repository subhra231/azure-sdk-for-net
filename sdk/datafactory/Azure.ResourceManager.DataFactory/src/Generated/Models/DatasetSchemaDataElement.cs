// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Columns that define the physical type schema of the dataset. </summary>
    public partial class DatasetSchemaDataElement
    {
        /// <summary> Initializes a new instance of DatasetSchemaDataElement. </summary>
        public DatasetSchemaDataElement()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of DatasetSchemaDataElement. </summary>
        /// <param name="schemaColumnName"> Name of the schema column. Type: string (or Expression with resultType string). </param>
        /// <param name="schemaColumnType"> Type of the schema column. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DatasetSchemaDataElement(DataFactoryElement<string> schemaColumnName, DataFactoryElement<string> schemaColumnType, IDictionary<string, BinaryData> additionalProperties)
        {
            SchemaColumnName = schemaColumnName;
            SchemaColumnType = schemaColumnType;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Name of the schema column. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SchemaColumnName { get; set; }
        /// <summary> Type of the schema column. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SchemaColumnType { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
