// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class ExhaustiveKnnVectorSearchAlgorithmConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("exhaustiveKnnParameters"u8);
                writer.WriteObjectValue(Parameters);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static ExhaustiveKnnVectorSearchAlgorithmConfiguration DeserializeExhaustiveKnnVectorSearchAlgorithmConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExhaustiveKnnParameters> exhaustiveKnnParameters = default;
            string name = default;
            VectorSearchAlgorithmKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exhaustiveKnnParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exhaustiveKnnParameters = ExhaustiveKnnParameters.DeserializeExhaustiveKnnParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new VectorSearchAlgorithmKind(property.Value.GetString());
                    continue;
                }
            }
            return new ExhaustiveKnnVectorSearchAlgorithmConfiguration(name, kind, exhaustiveKnnParameters.Value);
        }
    }
}
