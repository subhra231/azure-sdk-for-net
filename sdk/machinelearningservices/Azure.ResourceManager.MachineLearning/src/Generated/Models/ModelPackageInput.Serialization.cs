// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ModelPackageInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("inputType"u8);
            writer.WriteStringValue(InputType.ToString());
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(MountPath))
            {
                if (MountPath != null)
                {
                    writer.WritePropertyName("mountPath"u8);
                    writer.WriteStringValue(MountPath);
                }
                else
                {
                    writer.WriteNull("mountPath");
                }
            }
            writer.WritePropertyName("path"u8);
            writer.WriteObjectValue(Path);
            writer.WriteEndObject();
        }

        internal static ModelPackageInput DeserializeModelPackageInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PackageInputType inputType = default;
            Optional<PackageInputDeliveryMode> mode = default;
            Optional<string> mountPath = default;
            PackageInputPathBase path = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputType"u8))
                {
                    inputType = new PackageInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new PackageInputDeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        mountPath = null;
                        continue;
                    }
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = PackageInputPathBase.DeserializePackageInputPathBase(property.Value);
                    continue;
                }
            }
            return new ModelPackageInput(inputType, Optional.ToNullable(mode), mountPath.Value, path);
        }
    }
}
