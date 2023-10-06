// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Encryption at rest settings for disk restore point. It is an optional property that can be specified in the input while creating a restore point. </summary>
    public partial class RestorePointEncryption
    {
        /// <summary> Initializes a new instance of RestorePointEncryption. </summary>
        public RestorePointEncryption()
        {
        }

        /// <summary> Initializes a new instance of RestorePointEncryption. </summary>
        /// <param name="diskEncryptionSet"> Describes the parameter of customer managed disk encryption set resource id that can be specified for disk. **Note:** The disk encryption set resource id can only be specified for managed disk. Please refer https://aka.ms/mdssewithcmkoverview for more details. </param>
        /// <param name="encryptionType"> The type of key used to encrypt the data of the disk restore point. </param>
        internal RestorePointEncryption(WritableSubResource diskEncryptionSet, RestorePointEncryptionType? encryptionType)
        {
            DiskEncryptionSet = diskEncryptionSet;
            EncryptionType = encryptionType;
        }

        /// <summary> Describes the parameter of customer managed disk encryption set resource id that can be specified for disk. **Note:** The disk encryption set resource id can only be specified for managed disk. Please refer https://aka.ms/mdssewithcmkoverview for more details. </summary>
        internal WritableSubResource DiskEncryptionSet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId
        {
            get => DiskEncryptionSet is null ? default : DiskEncryptionSet.Id;
            set
            {
                if (DiskEncryptionSet is null)
                    DiskEncryptionSet = new WritableSubResource();
                DiskEncryptionSet.Id = value;
            }
        }

        /// <summary> The type of key used to encrypt the data of the disk restore point. </summary>
        public RestorePointEncryptionType? EncryptionType { get; set; }
    }
}
