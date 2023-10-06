// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The PendingUploadResponseDto. </summary>
    public partial class PendingUploadResponseDto
    {
        /// <summary> Initializes a new instance of PendingUploadResponseDto. </summary>
        internal PendingUploadResponseDto()
        {
        }

        /// <summary> Initializes a new instance of PendingUploadResponseDto. </summary>
        /// <param name="blobReferenceForConsumption"> Container level read, write, list SAS. </param>
        /// <param name="pendingUploadId"> ID for this upload request. </param>
        /// <param name="pendingUploadType"> TemporaryBlobReference is the only supported type. </param>
        internal PendingUploadResponseDto(BlobReferenceForConsumptionDto blobReferenceForConsumption, string pendingUploadId, PendingUploadType? pendingUploadType)
        {
            BlobReferenceForConsumption = blobReferenceForConsumption;
            PendingUploadId = pendingUploadId;
            PendingUploadType = pendingUploadType;
        }

        /// <summary> Container level read, write, list SAS. </summary>
        public BlobReferenceForConsumptionDto BlobReferenceForConsumption { get; }
        /// <summary> ID for this upload request. </summary>
        public string PendingUploadId { get; }
        /// <summary> TemporaryBlobReference is the only supported type. </summary>
        public PendingUploadType? PendingUploadType { get; }
    }
}
