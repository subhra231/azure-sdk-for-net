// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Preferences related to the double encryption. </summary>
    internal partial class EncryptionPreferences
    {
        /// <summary> Initializes a new instance of EncryptionPreferences. </summary>
        public EncryptionPreferences()
        {
        }

        /// <summary> Initializes a new instance of EncryptionPreferences. </summary>
        /// <param name="doubleEncryptionStatus"> Double encryption status as entered by the customer. It is compulsory to give this parameter if the 'Deny' or 'Disabled' policy is configured. </param>
        internal EncryptionPreferences(DoubleEncryptionStatus? doubleEncryptionStatus)
        {
            DoubleEncryptionStatus = doubleEncryptionStatus;
        }

        /// <summary> Double encryption status as entered by the customer. It is compulsory to give this parameter if the 'Deny' or 'Disabled' policy is configured. </summary>
        public DoubleEncryptionStatus? DoubleEncryptionStatus { get; set; }
    }
}
