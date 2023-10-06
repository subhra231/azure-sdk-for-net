// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ImageRepositoryCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            writer.WritePropertyName("registryUrl"u8);
            writer.WriteStringValue(RegistryUriString);
            writer.WritePropertyName("username"u8);
            writer.WriteStringValue(Username);
            writer.WriteEndObject();
        }

        internal static ImageRepositoryCredentials DeserializeImageRepositoryCredentials(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> password = default;
            string registryUrl = default;
            string username = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryUrl"u8))
                {
                    registryUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
            }
            return new ImageRepositoryCredentials(password.Value, registryUrl, username);
        }
    }
}
