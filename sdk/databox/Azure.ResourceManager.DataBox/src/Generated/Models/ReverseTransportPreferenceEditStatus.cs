// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Editable status for Reverse Transport preferences. </summary>
    public enum ReverseTransportPreferenceEditStatus
    {
        /// <summary> Reverse Transport Preferences can be edited. </summary>
        Enabled,
        /// <summary> Edit is disabled for Reverse Transport Preferences. </summary>
        Disabled,
        /// <summary> Edit is not supported for Reverse Transport Preferences. Either subscription feature is not available or SKU doesn't support this feature. </summary>
        NotSupported
    }
}
