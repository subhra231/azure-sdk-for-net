// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01. </summary>
    public partial class UefiSettings
    {
        /// <summary> Initializes a new instance of UefiSettings. </summary>
        public UefiSettings()
        {
        }

        /// <summary> Initializes a new instance of UefiSettings. </summary>
        /// <param name="isSecureBootEnabled"> Specifies whether secure boot should be enabled on the virtual machine. Minimum api-version: 2020-12-01. </param>
        /// <param name="isVirtualTpmEnabled"> Specifies whether vTPM should be enabled on the virtual machine. Minimum api-version: 2020-12-01. </param>
        internal UefiSettings(bool? isSecureBootEnabled, bool? isVirtualTpmEnabled)
        {
            IsSecureBootEnabled = isSecureBootEnabled;
            IsVirtualTpmEnabled = isVirtualTpmEnabled;
        }

        /// <summary> Specifies whether secure boot should be enabled on the virtual machine. Minimum api-version: 2020-12-01. </summary>
        public bool? IsSecureBootEnabled { get; set; }
        /// <summary> Specifies whether vTPM should be enabled on the virtual machine. Minimum api-version: 2020-12-01. </summary>
        public bool? IsVirtualTpmEnabled { get; set; }
    }
}
