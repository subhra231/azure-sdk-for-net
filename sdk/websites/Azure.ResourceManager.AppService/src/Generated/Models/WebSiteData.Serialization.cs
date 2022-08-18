// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class WebSiteData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(HostNameSslStates))
            {
                writer.WritePropertyName("hostNameSslStates");
                writer.WriteStartArray();
                foreach (var item in HostNameSslStates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AppServicePlanId))
            {
                writer.WritePropertyName("serverFarmId");
                writer.WriteStringValue(AppServicePlanId);
            }
            if (Optional.IsDefined(IsReserved))
            {
                writer.WritePropertyName("reserved");
                writer.WriteBooleanValue(IsReserved.Value);
            }
            if (Optional.IsDefined(IsXenon))
            {
                writer.WritePropertyName("isXenon");
                writer.WriteBooleanValue(IsXenon.Value);
            }
            if (Optional.IsDefined(IsHyperV))
            {
                writer.WritePropertyName("hyperV");
                writer.WriteBooleanValue(IsHyperV.Value);
            }
            if (Optional.IsDefined(SiteConfig))
            {
                writer.WritePropertyName("siteConfig");
                writer.WriteObjectValue(SiteConfig);
            }
            if (Optional.IsDefined(ScmSiteAlsoStopped))
            {
                writer.WritePropertyName("scmSiteAlsoStopped");
                writer.WriteBooleanValue(ScmSiteAlsoStopped.Value);
            }
            if (Optional.IsDefined(HostingEnvironmentProfile))
            {
                if (HostingEnvironmentProfile != null)
                {
                    writer.WritePropertyName("hostingEnvironmentProfile");
                    writer.WriteObjectValue(HostingEnvironmentProfile);
                }
                else
                {
                    writer.WriteNull("hostingEnvironmentProfile");
                }
            }
            if (Optional.IsDefined(IsClientAffinityEnabled))
            {
                writer.WritePropertyName("clientAffinityEnabled");
                writer.WriteBooleanValue(IsClientAffinityEnabled.Value);
            }
            if (Optional.IsDefined(IsClientCertEnabled))
            {
                writer.WritePropertyName("clientCertEnabled");
                writer.WriteBooleanValue(IsClientCertEnabled.Value);
            }
            if (Optional.IsDefined(ClientCertMode))
            {
                writer.WritePropertyName("clientCertMode");
                writer.WriteStringValue(ClientCertMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(ClientCertExclusionPaths))
            {
                writer.WritePropertyName("clientCertExclusionPaths");
                writer.WriteStringValue(ClientCertExclusionPaths);
            }
            if (Optional.IsDefined(IsHostNameDisabled))
            {
                writer.WritePropertyName("hostNamesDisabled");
                writer.WriteBooleanValue(IsHostNameDisabled.Value);
            }
            if (Optional.IsDefined(CustomDomainVerificationId))
            {
                writer.WritePropertyName("customDomainVerificationId");
                writer.WriteStringValue(CustomDomainVerificationId);
            }
            if (Optional.IsDefined(ContainerSize))
            {
                writer.WritePropertyName("containerSize");
                writer.WriteNumberValue(ContainerSize.Value);
            }
            if (Optional.IsDefined(DailyMemoryTimeQuota))
            {
                writer.WritePropertyName("dailyMemoryTimeQuota");
                writer.WriteNumberValue(DailyMemoryTimeQuota.Value);
            }
            if (Optional.IsDefined(CloningInfo))
            {
                if (CloningInfo != null)
                {
                    writer.WritePropertyName("cloningInfo");
                    writer.WriteObjectValue(CloningInfo);
                }
                else
                {
                    writer.WriteNull("cloningInfo");
                }
            }
            if (Optional.IsDefined(IsHttpsOnly))
            {
                writer.WritePropertyName("httpsOnly");
                writer.WriteBooleanValue(IsHttpsOnly.Value);
            }
            if (Optional.IsDefined(RedundancyMode))
            {
                writer.WritePropertyName("redundancyMode");
                writer.WriteStringValue(RedundancyMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsStorageAccountRequired))
            {
                writer.WritePropertyName("storageAccountRequired");
                writer.WriteBooleanValue(IsStorageAccountRequired.Value);
            }
            if (Optional.IsDefined(KeyVaultReferenceIdentity))
            {
                writer.WritePropertyName("keyVaultReferenceIdentity");
                writer.WriteStringValue(KeyVaultReferenceIdentity);
            }
            if (Optional.IsDefined(VirtualNetworkSubnetId))
            {
                writer.WritePropertyName("virtualNetworkSubnetId");
                writer.WriteStringValue(VirtualNetworkSubnetId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebSiteData DeserializeWebSiteData(JsonElement element)
        {
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> state = default;
            Optional<IReadOnlyList<string>> hostNames = default;
            Optional<string> repositorySiteName = default;
            Optional<UsageState> usageState = default;
            Optional<bool> enabled = default;
            Optional<IReadOnlyList<string>> enabledHostNames = default;
            Optional<WebSiteAvailabilityState> availabilityState = default;
            Optional<IList<HostNameSslState>> hostNameSslStates = default;
            Optional<string> serverFarmId = default;
            Optional<bool> reserved = default;
            Optional<bool> isXenon = default;
            Optional<bool> hyperV = default;
            Optional<DateTimeOffset> lastModifiedTimeUtc = default;
            Optional<SiteConfigProperties> siteConfig = default;
            Optional<IReadOnlyList<string>> trafficManagerHostNames = default;
            Optional<bool> scmSiteAlsoStopped = default;
            Optional<string> targetSwapSlot = default;
            Optional<HostingEnvironmentProfile> hostingEnvironmentProfile = default;
            Optional<bool> clientAffinityEnabled = default;
            Optional<bool> clientCertEnabled = default;
            Optional<ClientCertMode> clientCertMode = default;
            Optional<string> clientCertExclusionPaths = default;
            Optional<bool> hostNamesDisabled = default;
            Optional<string> customDomainVerificationId = default;
            Optional<string> outboundIPAddresses = default;
            Optional<string> possibleOutboundIPAddresses = default;
            Optional<int> containerSize = default;
            Optional<int> dailyMemoryTimeQuota = default;
            Optional<DateTimeOffset?> suspendedTill = default;
            Optional<int?> maxNumberOfWorkers = default;
            Optional<CloningInfo> cloningInfo = default;
            Optional<string> resourceGroup = default;
            Optional<bool> isDefaultContainer = default;
            Optional<string> defaultHostName = default;
            Optional<SlotSwapStatus> slotSwapStatus = default;
            Optional<bool> httpsOnly = default;
            Optional<RedundancyMode> redundancyMode = default;
            Optional<Guid?> inProgressOperationId = default;
            Optional<bool> storageAccountRequired = default;
            Optional<string> keyVaultReferenceIdentity = default;
            Optional<string> virtualNetworkSubnetId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            hostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("repositorySiteName"))
                        {
                            repositorySiteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usageState = property0.Value.GetString().ToUsageState();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enabledHostNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            enabledHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("availabilityState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            availabilityState = property0.Value.GetString().ToWebSiteAvailabilityState();
                            continue;
                        }
                        if (property0.NameEquals("hostNameSslStates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<HostNameSslState> array = new List<HostNameSslState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HostNameSslState.DeserializeHostNameSslState(item));
                            }
                            hostNameSslStates = array;
                            continue;
                        }
                        if (property0.NameEquals("serverFarmId"))
                        {
                            serverFarmId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reserved"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reserved = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isXenon"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isXenon = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hyperV"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hyperV = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTimeUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("siteConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            siteConfig = SiteConfigProperties.DeserializeSiteConfigProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("trafficManagerHostNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                trafficManagerHostNames = null;
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            trafficManagerHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("scmSiteAlsoStopped"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scmSiteAlsoStopped = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("targetSwapSlot"))
                        {
                            targetSwapSlot = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                hostingEnvironmentProfile = null;
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientAffinityEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientAffinityEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clientCertEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientCertEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clientCertMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientCertMode = property0.Value.GetString().ToClientCertMode();
                            continue;
                        }
                        if (property0.NameEquals("clientCertExclusionPaths"))
                        {
                            clientCertExclusionPaths = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostNamesDisabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hostNamesDisabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationId"))
                        {
                            customDomainVerificationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("outboundIpAddresses"))
                        {
                            outboundIPAddresses = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("possibleOutboundIpAddresses"))
                        {
                            possibleOutboundIPAddresses = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            containerSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dailyMemoryTimeQuota"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dailyMemoryTimeQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("suspendedTill"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                suspendedTill = null;
                                continue;
                            }
                            suspendedTill = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfWorkers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                maxNumberOfWorkers = null;
                                continue;
                            }
                            maxNumberOfWorkers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("cloningInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cloningInfo = null;
                                continue;
                            }
                            cloningInfo = CloningInfo.DeserializeCloningInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDefaultContainer"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDefaultContainer = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultHostName"))
                        {
                            defaultHostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("slotSwapStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                slotSwapStatus = null;
                                continue;
                            }
                            slotSwapStatus = SlotSwapStatus.DeserializeSlotSwapStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpsOnly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            httpsOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("redundancyMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            redundancyMode = property0.Value.GetString().ToRedundancyMode();
                            continue;
                        }
                        if (property0.NameEquals("inProgressOperationId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                inProgressOperationId = null;
                                continue;
                            }
                            inProgressOperationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountRequired"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageAccountRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultReferenceIdentity"))
                        {
                            keyVaultReferenceIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkSubnetId"))
                        {
                            virtualNetworkSubnetId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebSiteData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, extendedLocation, state.Value, Optional.ToList(hostNames), repositorySiteName.Value, Optional.ToNullable(usageState), Optional.ToNullable(enabled), Optional.ToList(enabledHostNames), Optional.ToNullable(availabilityState), Optional.ToList(hostNameSslStates), serverFarmId.Value, Optional.ToNullable(reserved), Optional.ToNullable(isXenon), Optional.ToNullable(hyperV), Optional.ToNullable(lastModifiedTimeUtc), siteConfig.Value, Optional.ToList(trafficManagerHostNames), Optional.ToNullable(scmSiteAlsoStopped), targetSwapSlot.Value, hostingEnvironmentProfile.Value, Optional.ToNullable(clientAffinityEnabled), Optional.ToNullable(clientCertEnabled), Optional.ToNullable(clientCertMode), clientCertExclusionPaths.Value, Optional.ToNullable(hostNamesDisabled), customDomainVerificationId.Value, outboundIPAddresses.Value, possibleOutboundIPAddresses.Value, Optional.ToNullable(containerSize), Optional.ToNullable(dailyMemoryTimeQuota), Optional.ToNullable(suspendedTill), Optional.ToNullable(maxNumberOfWorkers), cloningInfo.Value, resourceGroup.Value, Optional.ToNullable(isDefaultContainer), defaultHostName.Value, slotSwapStatus.Value, Optional.ToNullable(httpsOnly), Optional.ToNullable(redundancyMode), Optional.ToNullable(inProgressOperationId), Optional.ToNullable(storageAccountRequired), keyVaultReferenceIdentity.Value, virtualNetworkSubnetId.Value, kind.Value);
        }
    }
}
