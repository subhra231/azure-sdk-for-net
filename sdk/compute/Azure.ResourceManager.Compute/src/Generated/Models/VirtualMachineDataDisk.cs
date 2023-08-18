// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a data disk. </summary>
    public partial class VirtualMachineDataDisk
    {
        /// <summary> Initializes a new instance of VirtualMachineDataDisk. </summary>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </param>
        /// <param name="createOption"> Specifies how the virtual machine should be created. Possible values are: **Attach.** This value is used when you are using a specialized disk to create the virtual machine. **FromImage.** This value is used when you are using an image to create the virtual machine. If you are using a platform image, you should also use the imageReference element described above. If you are using a marketplace image, you should also use the plan element previously described. </param>
        public VirtualMachineDataDisk(int lun, DiskCreateOptionType createOption)
        {
            Lun = lun;
            CreateOption = createOption;
        }

        /// <summary> Initializes a new instance of VirtualMachineDataDisk. </summary>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </param>
        /// <param name="name"> The disk name. </param>
        /// <param name="vhd"> The virtual hard disk. </param>
        /// <param name="image"> The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist. </param>
        /// <param name="caching"> Specifies the caching requirements. Possible values are: **None,** **ReadOnly,** **ReadWrite.** The defaulting behavior is: **None for Standard storage. ReadOnly for Premium storage.**. </param>
        /// <param name="writeAcceleratorEnabled"> Specifies whether writeAccelerator should be enabled or disabled on the disk. </param>
        /// <param name="createOption"> Specifies how the virtual machine should be created. Possible values are: **Attach.** This value is used when you are using a specialized disk to create the virtual machine. **FromImage.** This value is used when you are using an image to create the virtual machine. If you are using a platform image, you should also use the imageReference element described above. If you are using a marketplace image, you should also use the plan element previously described. </param>
        /// <param name="diskSizeGB"> Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB' is the number of bytes x 1024^3 for the disk and the value cannot be larger than 1023. </param>
        /// <param name="managedDisk"> The managed disk parameters. </param>
        /// <param name="toBeDetached"> Specifies whether the data disk is in process of detachment from the VirtualMachine/VirtualMachineScaleset. </param>
        /// <param name="diskIopsReadWrite"> Specifies the Read-Write IOPS for the managed disk when StorageAccountType is UltraSSD_LRS. Returned only for VirtualMachine ScaleSet VM disks. Can be updated only via updates to the VirtualMachine Scale Set. </param>
        /// <param name="diskMBpsReadWrite"> Specifies the bandwidth in MB per second for the managed disk when StorageAccountType is UltraSSD_LRS. Returned only for VirtualMachine ScaleSet VM disks. Can be updated only via updates to the VirtualMachine Scale Set. </param>
        /// <param name="detachOption"> Specifies the detach behavior to be used while detaching a disk or which is already in the process of detachment from the virtual machine. Supported values: **ForceDetach.** detachOption: **ForceDetach** is applicable only for managed data disks. If a previous detachment attempt of the data disk did not complete due to an unexpected failure from the virtual machine and the disk is still not released then use force-detach as a last resort option to detach the disk forcibly from the VM. All writes might not have been flushed when using this detach behavior. **This feature is still in preview** mode and is not supported for VirtualMachineScaleSet. To force-detach a data disk update toBeDetached to 'true' along with setting detachOption: 'ForceDetach'. </param>
        /// <param name="deleteOption"> Specifies whether data disk should be deleted or detached upon VM deletion. Possible values are: **Delete.** If this value is used, the data disk is deleted when VM is deleted. **Detach.** If this value is used, the data disk is retained after VM is deleted. The default value is set to **Detach**. </param>
        internal VirtualMachineDataDisk(int lun, string name, VirtualHardDisk vhd, VirtualHardDisk image, CachingType? caching, bool? writeAcceleratorEnabled, DiskCreateOptionType createOption, int? diskSizeGB, VirtualMachineManagedDisk managedDisk, bool? toBeDetached, long? diskIopsReadWrite, long? diskMBpsReadWrite, DiskDetachOptionType? detachOption, DiskDeleteOptionType? deleteOption)
        {
            Lun = lun;
            Name = name;
            Vhd = vhd;
            Image = image;
            Caching = caching;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            ToBeDetached = toBeDetached;
            DiskIopsReadWrite = diskIopsReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DetachOption = detachOption;
            DeleteOption = deleteOption;
        }

        /// <summary> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </summary>
        public int Lun { get; set; }
        /// <summary> The disk name. </summary>
        public string Name { get; set; }
        /// <summary> The virtual hard disk. </summary>
        internal VirtualHardDisk Vhd { get; set; }
        /// <summary> Specifies the virtual hard disk's uri. </summary>
        public Uri VhdUri
        {
            get => Vhd is null ? default : Vhd.Uri;
            set
            {
                if (Vhd is null)
                    Vhd = new VirtualHardDisk();
                Vhd.Uri = value;
            }
        }

        /// <summary> The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist. </summary>
        internal VirtualHardDisk Image { get; set; }
        /// <summary> Specifies the virtual hard disk's uri. </summary>
        public Uri ImageUri
        {
            get => Image is null ? default : Image.Uri;
            set
            {
                if (Image is null)
                    Image = new VirtualHardDisk();
                Image.Uri = value;
            }
        }

        /// <summary> Specifies the caching requirements. Possible values are: **None,** **ReadOnly,** **ReadWrite.** The defaulting behavior is: **None for Standard storage. ReadOnly for Premium storage.**. </summary>
        public CachingType? Caching { get; set; }
        /// <summary> Specifies whether writeAccelerator should be enabled or disabled on the disk. </summary>
        public bool? WriteAcceleratorEnabled { get; set; }
        /// <summary> Specifies how the virtual machine should be created. Possible values are: **Attach.** This value is used when you are using a specialized disk to create the virtual machine. **FromImage.** This value is used when you are using an image to create the virtual machine. If you are using a platform image, you should also use the imageReference element described above. If you are using a marketplace image, you should also use the plan element previously described. </summary>
        public DiskCreateOptionType CreateOption { get; set; }
        /// <summary> Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB' is the number of bytes x 1024^3 for the disk and the value cannot be larger than 1023. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> The managed disk parameters. </summary>
        public VirtualMachineManagedDisk ManagedDisk { get; set; }
        /// <summary> Specifies whether the data disk is in process of detachment from the VirtualMachine/VirtualMachineScaleset. </summary>
        public bool? ToBeDetached { get; set; }
        /// <summary> Specifies the Read-Write IOPS for the managed disk when StorageAccountType is UltraSSD_LRS. Returned only for VirtualMachine ScaleSet VM disks. Can be updated only via updates to the VirtualMachine Scale Set. </summary>
        public long? DiskIopsReadWrite { get; }
        /// <summary> Specifies the bandwidth in MB per second for the managed disk when StorageAccountType is UltraSSD_LRS. Returned only for VirtualMachine ScaleSet VM disks. Can be updated only via updates to the VirtualMachine Scale Set. </summary>
        public long? DiskMBpsReadWrite { get; }
        /// <summary> Specifies the detach behavior to be used while detaching a disk or which is already in the process of detachment from the virtual machine. Supported values: **ForceDetach.** detachOption: **ForceDetach** is applicable only for managed data disks. If a previous detachment attempt of the data disk did not complete due to an unexpected failure from the virtual machine and the disk is still not released then use force-detach as a last resort option to detach the disk forcibly from the VM. All writes might not have been flushed when using this detach behavior. **This feature is still in preview** mode and is not supported for VirtualMachineScaleSet. To force-detach a data disk update toBeDetached to 'true' along with setting detachOption: 'ForceDetach'. </summary>
        public DiskDetachOptionType? DetachOption { get; set; }
        /// <summary> Specifies whether data disk should be deleted or detached upon VM deletion. Possible values are: **Delete.** If this value is used, the data disk is deleted when VM is deleted. **Detach.** If this value is used, the data disk is retained after VM is deleted. The default value is set to **Detach**. </summary>
        public DiskDeleteOptionType? DeleteOption { get; set; }
    }
}
