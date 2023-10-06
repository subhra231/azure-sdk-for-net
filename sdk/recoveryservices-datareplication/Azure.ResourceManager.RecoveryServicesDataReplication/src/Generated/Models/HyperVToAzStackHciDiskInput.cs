// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> HyperVToAzStack disk input. </summary>
    public partial class HyperVToAzStackHciDiskInput
    {
        /// <summary> Initializes a new instance of HyperVToAzStackHciDiskInput. </summary>
        /// <param name="diskId"> Gets or sets the disk Id. </param>
        /// <param name="diskSizeGB"> Gets or sets the disk size in GB. </param>
        /// <param name="diskFileFormat"> Gets or sets the type of the virtual hard disk, vhd or vhdx. </param>
        /// <param name="isOSDisk"> Gets or sets a value indicating whether disk is os disk. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/> or <paramref name="diskFileFormat"/> is null. </exception>
        public HyperVToAzStackHciDiskInput(string diskId, long diskSizeGB, string diskFileFormat, bool isOSDisk)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));
            Argument.AssertNotNull(diskFileFormat, nameof(diskFileFormat));

            DiskId = diskId;
            DiskSizeGB = diskSizeGB;
            DiskFileFormat = diskFileFormat;
            IsOSDisk = isOSDisk;
        }

        /// <summary> Initializes a new instance of HyperVToAzStackHciDiskInput. </summary>
        /// <param name="diskId"> Gets or sets the disk Id. </param>
        /// <param name="storageContainerId"> Gets or sets the target storage account ARM Id. </param>
        /// <param name="isDynamic">
        /// Gets or sets a value indicating whether dynamic sizing is enabled on the virtual hard
        /// disk.
        /// </param>
        /// <param name="diskSizeGB"> Gets or sets the disk size in GB. </param>
        /// <param name="diskFileFormat"> Gets or sets the type of the virtual hard disk, vhd or vhdx. </param>
        /// <param name="isOSDisk"> Gets or sets a value indicating whether disk is os disk. </param>
        internal HyperVToAzStackHciDiskInput(string diskId, ResourceIdentifier storageContainerId, bool? isDynamic, long diskSizeGB, string diskFileFormat, bool isOSDisk)
        {
            DiskId = diskId;
            StorageContainerId = storageContainerId;
            IsDynamic = isDynamic;
            DiskSizeGB = diskSizeGB;
            DiskFileFormat = diskFileFormat;
            IsOSDisk = isOSDisk;
        }

        /// <summary> Gets or sets the disk Id. </summary>
        public string DiskId { get; set; }
        /// <summary> Gets or sets the target storage account ARM Id. </summary>
        public ResourceIdentifier StorageContainerId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether dynamic sizing is enabled on the virtual hard
        /// disk.
        /// </summary>
        public bool? IsDynamic { get; set; }
        /// <summary> Gets or sets the disk size in GB. </summary>
        public long DiskSizeGB { get; set; }
        /// <summary> Gets or sets the type of the virtual hard disk, vhd or vhdx. </summary>
        public string DiskFileFormat { get; set; }
        /// <summary> Gets or sets a value indicating whether disk is os disk. </summary>
        public bool IsOSDisk { get; set; }
    }
}
