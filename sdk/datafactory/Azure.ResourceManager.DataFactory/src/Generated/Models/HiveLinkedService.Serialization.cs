// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class HiveLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("host");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Host);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Host.ToString()).RootElement);
#endif
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Port);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Port.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ServerType))
            {
                writer.WritePropertyName("serverType");
                writer.WriteStringValue(ServerType.Value.ToString());
            }
            if (Optional.IsDefined(ThriftTransportProtocol))
            {
                writer.WritePropertyName("thriftTransportProtocol");
                writer.WriteStringValue(ThriftTransportProtocol.Value.ToString());
            }
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            if (Optional.IsDefined(ServiceDiscoveryMode))
            {
                writer.WritePropertyName("serviceDiscoveryMode");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ServiceDiscoveryMode);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ServiceDiscoveryMode.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ZooKeeperNameSpace))
            {
                writer.WritePropertyName("zooKeeperNameSpace");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ZooKeeperNameSpace);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ZooKeeperNameSpace.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(UseNativeQuery))
            {
                writer.WritePropertyName("useNativeQuery");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UseNativeQuery);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UseNativeQuery.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Username);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Username.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(HttpPath))
            {
                writer.WritePropertyName("httpPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HttpPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(HttpPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EnableSsl))
            {
                writer.WritePropertyName("enableSsl");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EnableSsl);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EnableSsl.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(TrustedCertPath))
            {
                writer.WritePropertyName("trustedCertPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TrustedCertPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(TrustedCertPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(UseSystemTrustStore))
            {
                writer.WritePropertyName("useSystemTrustStore");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UseSystemTrustStore);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UseSystemTrustStore.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AllowHostNameCNMismatch))
            {
                writer.WritePropertyName("allowHostNameCNMismatch");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AllowHostNameCNMismatch);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AllowHostNameCNMismatch.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AllowSelfSignedServerCert))
            {
                writer.WritePropertyName("allowSelfSignedServerCert");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AllowSelfSignedServerCert);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AllowSelfSignedServerCert.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EncryptedCredential);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EncryptedCredential.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static HiveLinkedService DeserializeHiveLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            BinaryData host = default;
            Optional<BinaryData> port = default;
            Optional<HiveServerType> serverType = default;
            Optional<HiveThriftTransportProtocol> thriftTransportProtocol = default;
            HiveAuthenticationType authenticationType = default;
            Optional<BinaryData> serviceDiscoveryMode = default;
            Optional<BinaryData> zooKeeperNameSpace = default;
            Optional<BinaryData> useNativeQuery = default;
            Optional<BinaryData> username = default;
            Optional<FactorySecretBaseDefinition> password = default;
            Optional<BinaryData> httpPath = default;
            Optional<BinaryData> enableSsl = default;
            Optional<BinaryData> trustedCertPath = default;
            Optional<BinaryData> useSystemTrustStore = default;
            Optional<BinaryData> allowHostNameCNMismatch = default;
            Optional<BinaryData> allowSelfSignedServerCert = default;
            Optional<BinaryData> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("host"))
                        {
                            host = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("serverType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverType = new HiveServerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("thriftTransportProtocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            thriftTransportProtocol = new HiveThriftTransportProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"))
                        {
                            authenticationType = new HiveAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceDiscoveryMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serviceDiscoveryMode = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("zooKeeperNameSpace"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            zooKeeperNameSpace = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("useNativeQuery"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useNativeQuery = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("username"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            username = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            password = FactorySecretBaseDefinition.DeserializeFactorySecretBaseDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            httpPath = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("enableSsl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableSsl = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("trustedCertPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trustedCertPath = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("useSystemTrustStore"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useSystemTrustStore = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("allowHostNameCNMismatch"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowHostNameCNMismatch = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("allowSelfSignedServerCert"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowSelfSignedServerCert = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HiveLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, host, port.Value, Optional.ToNullable(serverType), Optional.ToNullable(thriftTransportProtocol), authenticationType, serviceDiscoveryMode.Value, zooKeeperNameSpace.Value, useNativeQuery.Value, username.Value, password.Value, httpPath.Value, enableSsl.Value, trustedCertPath.Value, useSystemTrustStore.Value, allowHostNameCNMismatch.Value, allowSelfSignedServerCert.Value, encryptedCredential.Value);
        }
    }
}
