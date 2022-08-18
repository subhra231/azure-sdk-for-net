// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class H265Layer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile");
                writer.WriteStringValue(Profile.Value.ToString());
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level");
                writer.WriteStringValue(Level);
            }
            if (Optional.IsDefined(BufferWindow))
            {
                writer.WritePropertyName("bufferWindow");
                writer.WriteStringValue(BufferWindow.Value, "P");
            }
            if (Optional.IsDefined(Crf))
            {
                writer.WritePropertyName("crf");
                writer.WriteNumberValue(Crf.Value);
            }
            if (Optional.IsDefined(ReferenceFrames))
            {
                writer.WritePropertyName("referenceFrames");
                writer.WriteNumberValue(ReferenceFrames.Value);
            }
            writer.WritePropertyName("bitrate");
            writer.WriteNumberValue(Bitrate);
            if (Optional.IsDefined(MaxBitrate))
            {
                writer.WritePropertyName("maxBitrate");
                writer.WriteNumberValue(MaxBitrate.Value);
            }
            if (Optional.IsDefined(BFrames))
            {
                writer.WritePropertyName("bFrames");
                writer.WriteNumberValue(BFrames.Value);
            }
            if (Optional.IsDefined(FrameRate))
            {
                writer.WritePropertyName("frameRate");
                writer.WriteStringValue(FrameRate);
            }
            if (Optional.IsDefined(Slices))
            {
                writer.WritePropertyName("slices");
                writer.WriteNumberValue(Slices.Value);
            }
            if (Optional.IsDefined(UseAdaptiveBFrame))
            {
                writer.WritePropertyName("adaptiveBFrame");
                writer.WriteBooleanValue(UseAdaptiveBFrame.Value);
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width");
                writer.WriteStringValue(Width);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height");
                writer.WriteStringValue(Height);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            writer.WriteEndObject();
        }

        internal static H265Layer DeserializeH265Layer(JsonElement element)
        {
            Optional<H265VideoProfile> profile = default;
            Optional<string> level = default;
            Optional<TimeSpan> bufferWindow = default;
            Optional<float> crf = default;
            Optional<int> referenceFrames = default;
            int bitrate = default;
            Optional<int> maxBitrate = default;
            Optional<int> bFrames = default;
            Optional<string> frameRate = default;
            Optional<int> slices = default;
            Optional<bool> adaptiveBFrame = default;
            Optional<string> width = default;
            Optional<string> height = default;
            Optional<string> label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    profile = new H265VideoProfile(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("level"))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bufferWindow"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bufferWindow = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("crf"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    crf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("referenceFrames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    referenceFrames = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bitrate"))
                {
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxBitrate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxBitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bFrames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bFrames = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frameRate"))
                {
                    frameRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    slices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("adaptiveBFrame"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    adaptiveBFrame = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("width"))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"))
                {
                    height = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new H265Layer(width.Value, height.Value, label.Value, bitrate, Optional.ToNullable(maxBitrate), Optional.ToNullable(bFrames), frameRate.Value, Optional.ToNullable(slices), Optional.ToNullable(adaptiveBFrame), Optional.ToNullable(profile), level.Value, Optional.ToNullable(bufferWindow), Optional.ToNullable(crf), Optional.ToNullable(referenceFrames));
        }
    }
}
