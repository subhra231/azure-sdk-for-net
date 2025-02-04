// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Represents key wrap metadata that a key wrapping provider can use to wrap/unwrap a client encryption key. </summary>
    public partial class CosmosDBKeyWrapMetadata
    {
        /// <summary> Initializes a new instance of CosmosDBKeyWrapMetadata. </summary>
        public CosmosDBKeyWrapMetadata()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBKeyWrapMetadata. </summary>
        /// <param name="name"> The name of associated KeyEncryptionKey (aka CustomerManagedKey). </param>
        /// <param name="cosmosDBKeyWrapMetadataType"> ProviderName of KeyStoreProvider. </param>
        /// <param name="value"> Reference / link to the KeyEncryptionKey. </param>
        /// <param name="algorithm"> Algorithm used in wrapping and unwrapping of the data encryption key. </param>
        internal CosmosDBKeyWrapMetadata(string name, string cosmosDBKeyWrapMetadataType, string value, string algorithm)
        {
            Name = name;
            CosmosDBKeyWrapMetadataType = cosmosDBKeyWrapMetadataType;
            Value = value;
            Algorithm = algorithm;
        }

        /// <summary> The name of associated KeyEncryptionKey (aka CustomerManagedKey). </summary>
        public string Name { get; set; }
        /// <summary> ProviderName of KeyStoreProvider. </summary>
        public string CosmosDBKeyWrapMetadataType { get; set; }
        /// <summary> Reference / link to the KeyEncryptionKey. </summary>
        public string Value { get; set; }
        /// <summary> Algorithm used in wrapping and unwrapping of the data encryption key. </summary>
        public string Algorithm { get; set; }
    }
}
