// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.IotHub;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmIotHubModelFactory
    {
        /// <summary> Initializes a new instance of IotHubDescriptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. </param>
        /// <param name="properties"> IotHub properties. </param>
        /// <param name="sku"> IotHub SKU info. </param>
        /// <param name="identity"> The managed identities for the IotHub. </param>
        /// <returns> A new <see cref="IotHub.IotHubDescriptionData"/> instance for mocking. </returns>
        public static IotHubDescriptionData IotHubDescriptionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ETag? etag = null, IotHubProperties properties = null, IotHubSkuInfo sku = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();

            return new IotHubDescriptionData(id, name, resourceType, systemData, tags, location, etag, properties, sku, identity);
        }

        /// <summary> Initializes a new instance of IotHubProperties. </summary>
        /// <param name="authorizationPolicies"> The shared access policies you can use to secure a connection to the IoT hub. </param>
        /// <param name="disableLocalAuth"> If true, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication. </param>
        /// <param name="disableDeviceSas"> If true, all device(including Edge devices but excluding modules) scoped SAS keys cannot be used for authentication. </param>
        /// <param name="disableModuleSas"> If true, all module scoped SAS keys cannot be used for authentication. </param>
        /// <param name="restrictOutboundNetworkAccess"> If true, egress from IotHub will be restricted to only the allowed FQDNs that are configured via allowedFqdnList. </param>
        /// <param name="allowedFqdns"> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Iot Hub. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="ipFilterRules"> The IP filter rules. </param>
        /// <param name="networkRuleSets"> Network Rule Set Properties of IotHub. </param>
        /// <param name="minTlsVersion"> Specifies the minimum TLS version to support for this hub. Can be set to "1.2" to have clients that use a TLS version below 1.2 to be rejected. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections created on this IotHub. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="state"> The hub state. </param>
        /// <param name="hostName"> The name of the host. </param>
        /// <param name="eventHubEndpoints"> The Event Hub-compatible endpoint properties. The only possible keys to this dictionary is events. This key has to be present in the dictionary while making create or update calls for the IoT hub. </param>
        /// <param name="routing"> The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging. </param>
        /// <param name="storageEndpoints"> The list of Azure Storage endpoints where you can upload files. Currently you can configure only one Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True, causes an error to be thrown. </param>
        /// <param name="messagingEndpoints"> The messaging endpoint properties for the file upload notification queue. </param>
        /// <param name="enableFileUploadNotifications"> If True, file upload notifications are enabled. </param>
        /// <param name="cloudToDevice"> The IoT hub cloud-to-device messaging properties. </param>
        /// <param name="comments"> IoT hub comments. </param>
        /// <param name="features"> The capabilities and features enabled for the IoT hub. </param>
        /// <param name="locations"> Primary and secondary location for iot hub. </param>
        /// <param name="enableDataResidency"> This property when set to true, will enable data residency, thus, disabling disaster recovery. </param>
        /// <returns> A new <see cref="Models.IotHubProperties"/> instance for mocking. </returns>
        public static IotHubProperties IotHubProperties(IEnumerable<SharedAccessSignatureAuthorizationRule> authorizationPolicies = null, bool? disableLocalAuth = null, bool? disableDeviceSas = null, bool? disableModuleSas = null, bool? restrictOutboundNetworkAccess = null, IEnumerable<string> allowedFqdns = null, IotHubPublicNetworkAccess? publicNetworkAccess = null, IEnumerable<IotHubIPFilterRule> ipFilterRules = null, IotHubNetworkRuleSetProperties networkRuleSets = null, string minTlsVersion = null, IEnumerable<IotHubPrivateEndpointConnectionData> privateEndpointConnections = null, string provisioningState = null, string state = null, string hostName = null, IDictionary<string, EventHubCompatibleEndpointProperties> eventHubEndpoints = null, IotHubRoutingProperties routing = null, IDictionary<string, IotHubStorageEndpointProperties> storageEndpoints = null, IDictionary<string, MessagingEndpointProperties> messagingEndpoints = null, bool? enableFileUploadNotifications = null, CloudToDeviceProperties cloudToDevice = null, string comments = null, IotHubCapability? features = null, IEnumerable<IotHubLocationDescription> locations = null, bool? enableDataResidency = null)
        {
            authorizationPolicies ??= new List<SharedAccessSignatureAuthorizationRule>();
            allowedFqdns ??= new List<string>();
            ipFilterRules ??= new List<IotHubIPFilterRule>();
            privateEndpointConnections ??= new List<IotHubPrivateEndpointConnectionData>();
            eventHubEndpoints ??= new Dictionary<string, EventHubCompatibleEndpointProperties>();
            storageEndpoints ??= new Dictionary<string, IotHubStorageEndpointProperties>();
            messagingEndpoints ??= new Dictionary<string, MessagingEndpointProperties>();
            locations ??= new List<IotHubLocationDescription>();

            return new IotHubProperties(authorizationPolicies?.ToList(), disableLocalAuth, disableDeviceSas, disableModuleSas, restrictOutboundNetworkAccess, allowedFqdns?.ToList(), publicNetworkAccess, ipFilterRules?.ToList(), networkRuleSets, minTlsVersion, privateEndpointConnections?.ToList(), provisioningState, state, hostName, eventHubEndpoints, routing, storageEndpoints, messagingEndpoints, enableFileUploadNotifications, cloudToDevice, comments, features, locations?.ToList(), enableDataResidency);
        }

        /// <summary> Initializes a new instance of IotHubPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a private endpoint connection. </param>
        /// <returns> A new <see cref="IotHub.IotHubPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static IotHubPrivateEndpointConnectionData IotHubPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IotHubPrivateEndpointConnectionProperties properties = null)
        {
            return new IotHubPrivateEndpointConnectionData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of EventHubCompatibleEndpointProperties. </summary>
        /// <param name="retentionTimeInDays"> The retention time for device-to-cloud messages in days. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages. </param>
        /// <param name="partitionCount"> The number of partitions for receiving device-to-cloud messages in the Event Hub-compatible endpoint. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages. </param>
        /// <param name="partitionIds"> The partition ids in the Event Hub-compatible endpoint. </param>
        /// <param name="eventHubCompatibleName"> The Event Hub-compatible name. </param>
        /// <param name="endpoint"> The Event Hub-compatible endpoint. </param>
        /// <returns> A new <see cref="Models.EventHubCompatibleEndpointProperties"/> instance for mocking. </returns>
        public static EventHubCompatibleEndpointProperties EventHubCompatibleEndpointProperties(long? retentionTimeInDays = null, int? partitionCount = null, IEnumerable<string> partitionIds = null, string eventHubCompatibleName = null, string endpoint = null)
        {
            partitionIds ??= new List<string>();

            return new EventHubCompatibleEndpointProperties(retentionTimeInDays, partitionCount, partitionIds?.ToList(), eventHubCompatibleName, endpoint);
        }

        /// <summary> Initializes a new instance of RoutingCosmosDBSqlApiProperties. </summary>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </param>
        /// <param name="id"> Id of the cosmos DB sql container endpoint. </param>
        /// <param name="subscriptionId"> The subscription identifier of the cosmos DB account. </param>
        /// <param name="resourceGroup"> The name of the resource group of the cosmos DB account. </param>
        /// <param name="endpointUri"> The url of the cosmos DB account. It must include the protocol https://. </param>
        /// <param name="authenticationType"> Method used to authenticate against the cosmos DB sql container endpoint. </param>
        /// <param name="userAssignedIdentity"> Managed identity properties of routing cosmos DB container endpoint. </param>
        /// <param name="primaryKey"> The primary key of the cosmos DB account. </param>
        /// <param name="secondaryKey"> The secondary key of the cosmos DB account. </param>
        /// <param name="databaseName"> The name of the cosmos DB database in the cosmos DB account. </param>
        /// <param name="containerName"> The name of the cosmos DB sql container in the cosmos DB database. </param>
        /// <param name="partitionKeyName"> The name of the partition key associated with this cosmos DB sql container if one exists. This is an optional parameter. </param>
        /// <param name="partitionKeyTemplate"> The template for generating a synthetic partition key value for use with this cosmos DB sql container. The template must include at least one of the following placeholders: {iothub}, {deviceid}, {DD}, {MM}, and {YYYY}. Any one placeholder may be specified at most once, but order and non-placeholder components are arbitrary. This parameter is only required if PartitionKeyName is specified. </param>
        /// <returns> A new <see cref="Models.RoutingCosmosDBSqlApiProperties"/> instance for mocking. </returns>
        public static RoutingCosmosDBSqlApiProperties RoutingCosmosDBSqlApiProperties(string name = null, string id = null, string subscriptionId = null, string resourceGroup = null, Uri endpointUri = null, IotHubAuthenticationType? authenticationType = null, ResourceIdentifier userAssignedIdentity = null, string primaryKey = null, string secondaryKey = null, string databaseName = null, string containerName = null, string partitionKeyName = null, string partitionKeyTemplate = null)
        {
            return new RoutingCosmosDBSqlApiProperties(name, id, subscriptionId, resourceGroup, endpointUri, authenticationType, userAssignedIdentity != null ? new ManagedIdentity(userAssignedIdentity) : null, primaryKey, secondaryKey, databaseName, containerName, partitionKeyName, partitionKeyTemplate);
        }

        /// <summary> Initializes a new instance of IotHubLocationDescription. </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="role"> The role of the region, can be either primary or secondary. The primary region is where the IoT hub is currently provisioned. The secondary region is the Azure disaster recovery (DR) paired region and also the region where the IoT hub can failover to. </param>
        /// <returns> A new <see cref="Models.IotHubLocationDescription"/> instance for mocking. </returns>
        public static IotHubLocationDescription IotHubLocationDescription(AzureLocation? location = null, IotHubReplicaRoleType? role = null)
        {
            return new IotHubLocationDescription(location, role);
        }

        /// <summary> Initializes a new instance of IotHubSkuInfo. </summary>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="tier"> The billing tier for the IoT hub. </param>
        /// <param name="capacity"> The number of provisioned IoT Hub units. See: https://docs.microsoft.com/azure/azure-subscription-service-limits#iot-hub-limits. </param>
        /// <returns> A new <see cref="Models.IotHubSkuInfo"/> instance for mocking. </returns>
        public static IotHubSkuInfo IotHubSkuInfo(IotHubSku name = default, IotHubSkuTier? tier = null, long? capacity = null)
        {
            return new IotHubSkuInfo(name, tier, capacity);
        }

        /// <summary> Initializes a new instance of IotHubRegistryStatistics. </summary>
        /// <param name="totalDeviceCount"> The total count of devices in the identity registry. </param>
        /// <param name="enabledDeviceCount"> The count of enabled devices in the identity registry. </param>
        /// <param name="disabledDeviceCount"> The count of disabled devices in the identity registry. </param>
        /// <returns> A new <see cref="Models.IotHubRegistryStatistics"/> instance for mocking. </returns>
        public static IotHubRegistryStatistics IotHubRegistryStatistics(long? totalDeviceCount = null, long? enabledDeviceCount = null, long? disabledDeviceCount = null)
        {
            return new IotHubRegistryStatistics(totalDeviceCount, enabledDeviceCount, disabledDeviceCount);
        }

        /// <summary> Initializes a new instance of IotHubSkuDescription. </summary>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="sku"> The type of the resource. </param>
        /// <param name="capacity"> IotHub capacity. </param>
        /// <returns> A new <see cref="Models.IotHubSkuDescription"/> instance for mocking. </returns>
        public static IotHubSkuDescription IotHubSkuDescription(ResourceType? resourceType = null, IotHubSkuInfo sku = null, IotHubCapacity capacity = null)
        {
            return new IotHubSkuDescription(resourceType, sku, capacity);
        }

        /// <summary> Initializes a new instance of IotHubCapacity. </summary>
        /// <param name="minimum"> The minimum number of units. </param>
        /// <param name="maximum"> The maximum number of units. </param>
        /// <param name="default"> The default number of units. </param>
        /// <param name="scaleType"> The type of the scaling enabled. </param>
        /// <returns> A new <see cref="Models.IotHubCapacity"/> instance for mocking. </returns>
        public static IotHubCapacity IotHubCapacity(long? minimum = null, long? maximum = null, long? @default = null, IotHubScaleType? scaleType = null)
        {
            return new IotHubCapacity(minimum, maximum, @default, scaleType);
        }

        /// <summary> Initializes a new instance of EventHubConsumerGroupInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The tags. </param>
        /// <param name="etag"> The etag. </param>
        /// <returns> A new <see cref="IotHub.EventHubConsumerGroupInfoData"/> instance for mocking. </returns>
        public static EventHubConsumerGroupInfoData EventHubConsumerGroupInfoData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IReadOnlyDictionary<string, BinaryData> properties = null, ETag? etag = null)
        {
            properties ??= new Dictionary<string, BinaryData>();

            return new EventHubConsumerGroupInfoData(id, name, resourceType, systemData, properties, etag);
        }

        /// <summary> Initializes a new instance of IotHubJobInfo. </summary>
        /// <param name="jobId"> The job identifier. </param>
        /// <param name="startOn"> The start time of the job. </param>
        /// <param name="endOn"> The time the job stopped processing. </param>
        /// <param name="jobType"> The type of the job. </param>
        /// <param name="status"> The status of the job. </param>
        /// <param name="failureReason"> If status == failed, this string containing the reason for the failure. </param>
        /// <param name="statusMessage"> The status message for the job. </param>
        /// <param name="parentJobId"> The job identifier of the parent job, if any. </param>
        /// <returns> A new <see cref="Models.IotHubJobInfo"/> instance for mocking. </returns>
        public static IotHubJobInfo IotHubJobInfo(string jobId = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IotHubJobType? jobType = null, IotHubJobStatus? status = null, string failureReason = null, string statusMessage = null, string parentJobId = null)
        {
            return new IotHubJobInfo(jobId, startOn, endOn, jobType, status, failureReason, statusMessage, parentJobId);
        }

        /// <summary> Initializes a new instance of IotHubQuotaMetricInfo. </summary>
        /// <param name="name"> The name of the quota metric. </param>
        /// <param name="currentValue"> The current value for the quota metric. </param>
        /// <param name="maxValue"> The maximum value of the quota metric. </param>
        /// <returns> A new <see cref="Models.IotHubQuotaMetricInfo"/> instance for mocking. </returns>
        public static IotHubQuotaMetricInfo IotHubQuotaMetricInfo(string name = null, long? currentValue = null, long? maxValue = null)
        {
            return new IotHubQuotaMetricInfo(name, currentValue, maxValue);
        }

        /// <summary> Initializes a new instance of IotHubEndpointHealthInfo. </summary>
        /// <param name="endpointId"> Id of the endpoint. </param>
        /// <param name="healthStatus"> Health statuses have following meanings. The 'healthy' status shows that the endpoint is accepting messages as expected. The 'unhealthy' status shows that the endpoint is not accepting messages as expected and IoT Hub is retrying to send data to this endpoint. The status of an unhealthy endpoint will be updated to healthy when IoT Hub has established an eventually consistent state of health. The 'dead' status shows that the endpoint is not accepting messages, after IoT Hub retried sending messages for the retrial period. See IoT Hub metrics to identify errors and monitor issues with endpoints. The 'unknown' status shows that the IoT Hub has not established a connection with the endpoint. No messages have been delivered to or rejected from this endpoint. </param>
        /// <param name="lastKnownError"> Last error obtained when a message failed to be delivered to iot hub. </param>
        /// <param name="lastKnownErrorOn"> Time at which the last known error occurred. </param>
        /// <param name="lastSuccessfulSendAttemptOn"> Last time iot hub successfully sent a message to the endpoint. </param>
        /// <param name="lastSendAttemptOn"> Last time iot hub tried to send a message to the endpoint. </param>
        /// <returns> A new <see cref="Models.IotHubEndpointHealthInfo"/> instance for mocking. </returns>
        public static IotHubEndpointHealthInfo IotHubEndpointHealthInfo(string endpointId = null, IotHubEndpointHealthStatus? healthStatus = null, string lastKnownError = null, DateTimeOffset? lastKnownErrorOn = null, DateTimeOffset? lastSuccessfulSendAttemptOn = null, DateTimeOffset? lastSendAttemptOn = null)
        {
            return new IotHubEndpointHealthInfo(endpointId, healthStatus, lastKnownError, lastKnownErrorOn, lastSuccessfulSendAttemptOn, lastSendAttemptOn);
        }

        /// <summary> Initializes a new instance of IotHubNameAvailabilityResponse. </summary>
        /// <param name="isNameAvailable"> The value which indicates whether the provided name is available. </param>
        /// <param name="reason"> The reason for unavailability. </param>
        /// <param name="message"> The detailed reason message. </param>
        /// <returns> A new <see cref="Models.IotHubNameAvailabilityResponse"/> instance for mocking. </returns>
        public static IotHubNameAvailabilityResponse IotHubNameAvailabilityResponse(bool? isNameAvailable = null, IotHubNameUnavailableReason? reason = null, string message = null)
        {
            return new IotHubNameAvailabilityResponse(isNameAvailable, reason, message);
        }

        /// <summary> Initializes a new instance of IotHubUserSubscriptionQuota. </summary>
        /// <param name="iotHubTypeId"> IotHub type id. </param>
        /// <param name="userSubscriptionQuotaType"> Response type. </param>
        /// <param name="unit"> Unit of IotHub type. </param>
        /// <param name="currentValue"> Current number of IotHub type. </param>
        /// <param name="limit"> Numerical limit on IotHub type. </param>
        /// <param name="name"> IotHub type. </param>
        /// <returns> A new <see cref="Models.IotHubUserSubscriptionQuota"/> instance for mocking. </returns>
        public static IotHubUserSubscriptionQuota IotHubUserSubscriptionQuota(string iotHubTypeId = null, string userSubscriptionQuotaType = null, string unit = null, int? currentValue = null, int? limit = null, IotHubTypeName name = null)
        {
            return new IotHubUserSubscriptionQuota(iotHubTypeId, userSubscriptionQuotaType, unit, currentValue, limit, name);
        }

        /// <summary> Initializes a new instance of IotHubTypeName. </summary>
        /// <param name="value"> IotHub type. </param>
        /// <param name="localizedValue"> Localized value of name. </param>
        /// <returns> A new <see cref="Models.IotHubTypeName"/> instance for mocking. </returns>
        public static IotHubTypeName IotHubTypeName(string value = null, string localizedValue = null)
        {
            return new IotHubTypeName(value, localizedValue);
        }

        /// <summary> Initializes a new instance of IotHubTestAllRoutesResult. </summary>
        /// <param name="routes"> JSON-serialized array of matched routes. </param>
        /// <returns> A new <see cref="Models.IotHubTestAllRoutesResult"/> instance for mocking. </returns>
        public static IotHubTestAllRoutesResult IotHubTestAllRoutesResult(IEnumerable<IotHubMatchedRoute> routes = null)
        {
            routes ??= new List<IotHubMatchedRoute>();

            return new IotHubTestAllRoutesResult(routes?.ToList());
        }

        /// <summary> Initializes a new instance of IotHubMatchedRoute. </summary>
        /// <param name="properties"> Properties of routes that matched. </param>
        /// <returns> A new <see cref="Models.IotHubMatchedRoute"/> instance for mocking. </returns>
        public static IotHubMatchedRoute IotHubMatchedRoute(RoutingRuleProperties properties = null)
        {
            return new IotHubMatchedRoute(properties);
        }

        /// <summary> Initializes a new instance of IotHubTestRouteResult. </summary>
        /// <param name="result"> Result of testing route. </param>
        /// <param name="detailsCompilationErrors"> Detailed result of testing route. </param>
        /// <returns> A new <see cref="Models.IotHubTestRouteResult"/> instance for mocking. </returns>
        public static IotHubTestRouteResult IotHubTestRouteResult(IotHubTestResultStatus? result = null, IEnumerable<RouteCompilationError> detailsCompilationErrors = null)
        {
            detailsCompilationErrors ??= new List<RouteCompilationError>();

            return new IotHubTestRouteResult(result, detailsCompilationErrors != null ? new IotHubTestRouteResultDetails(detailsCompilationErrors?.ToList()) : null);
        }

        /// <summary> Initializes a new instance of RouteCompilationError. </summary>
        /// <param name="message"> Route error message. </param>
        /// <param name="severity"> Severity of the route error. </param>
        /// <param name="location"> Location where the route error happened. </param>
        /// <returns> A new <see cref="Models.RouteCompilationError"/> instance for mocking. </returns>
        public static RouteCompilationError RouteCompilationError(string message = null, RouteErrorSeverity? severity = null, RouteErrorRange location = null)
        {
            return new RouteCompilationError(message, severity, location);
        }

        /// <summary> Initializes a new instance of RouteErrorRange. </summary>
        /// <param name="start"> Start where the route error happened. </param>
        /// <param name="end"> End where the route error happened. </param>
        /// <returns> A new <see cref="Models.RouteErrorRange"/> instance for mocking. </returns>
        public static RouteErrorRange RouteErrorRange(RouteErrorPosition start = null, RouteErrorPosition end = null)
        {
            return new RouteErrorRange(start, end);
        }

        /// <summary> Initializes a new instance of RouteErrorPosition. </summary>
        /// <param name="line"> Line where the route error happened. </param>
        /// <param name="column"> Column where the route error happened. </param>
        /// <returns> A new <see cref="Models.RouteErrorPosition"/> instance for mocking. </returns>
        public static RouteErrorPosition RouteErrorPosition(int? line = null, int? column = null)
        {
            return new RouteErrorPosition(line, column);
        }

        /// <summary> Initializes a new instance of IotHubCertificateDescriptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The description of an X509 CA Certificate. </param>
        /// <param name="etag"> The entity tag. </param>
        /// <returns> A new <see cref="IotHub.IotHubCertificateDescriptionData"/> instance for mocking. </returns>
        public static IotHubCertificateDescriptionData IotHubCertificateDescriptionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IotHubCertificateProperties properties = null, ETag? etag = null)
        {
            return new IotHubCertificateDescriptionData(id, name, resourceType, systemData, properties, etag);
        }

        /// <summary> Initializes a new instance of IotHubCertificateProperties. </summary>
        /// <param name="subject"> The certificate's subject name. </param>
        /// <param name="expireOn"> The certificate's expiration date and time. </param>
        /// <param name="thumbprintString"> The certificate's thumbprint. </param>
        /// <param name="isVerified"> Determines whether certificate has been verified. </param>
        /// <param name="createdOn"> The certificate's create date and time. </param>
        /// <param name="updatedOn"> The certificate's last update date and time. </param>
        /// <param name="certificate"> The certificate content. </param>
        /// <returns> A new <see cref="Models.IotHubCertificateProperties"/> instance for mocking. </returns>
        public static IotHubCertificateProperties IotHubCertificateProperties(string subject = null, DateTimeOffset? expireOn = null, string thumbprintString = null, bool? isVerified = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, BinaryData certificate = null)
        {
            return new IotHubCertificateProperties(subject, expireOn, thumbprintString, isVerified, createdOn, updatedOn, certificate);
        }

        /// <summary> Initializes a new instance of IotHubCertificateWithNonceDescription. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The description of an X509 CA Certificate including the challenge nonce issued for the Proof-Of-Possession flow. </param>
        /// <param name="etag"> The entity tag. </param>
        /// <returns> A new <see cref="Models.IotHubCertificateWithNonceDescription"/> instance for mocking. </returns>
        public static IotHubCertificateWithNonceDescription IotHubCertificateWithNonceDescription(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IotHubCertificatePropertiesWithNonce properties = null, ETag? etag = null)
        {
            return new IotHubCertificateWithNonceDescription(id, name, resourceType, systemData, properties, etag);
        }

        /// <summary> Initializes a new instance of IotHubCertificatePropertiesWithNonce. </summary>
        /// <param name="subject"> The certificate's subject name. </param>
        /// <param name="expireOn"> The certificate's expiration date and time. </param>
        /// <param name="thumbprintString"> The certificate's thumbprint. </param>
        /// <param name="isVerified"> Determines whether certificate has been verified. </param>
        /// <param name="createdOn"> The certificate's create date and time. </param>
        /// <param name="updatedOn"> The certificate's last update date and time. </param>
        /// <param name="verificationCode"> The certificate's verification code that will be used for proof of possession. </param>
        /// <param name="certificate"> The certificate content. </param>
        /// <returns> A new <see cref="Models.IotHubCertificatePropertiesWithNonce"/> instance for mocking. </returns>
        public static IotHubCertificatePropertiesWithNonce IotHubCertificatePropertiesWithNonce(string subject = null, DateTimeOffset? expireOn = null, string thumbprintString = null, bool? isVerified = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, string verificationCode = null, BinaryData certificate = null)
        {
            return new IotHubCertificatePropertiesWithNonce(subject, expireOn, thumbprintString, isVerified, createdOn, updatedOn, verificationCode, certificate);
        }

        /// <summary> Initializes a new instance of IotHubPrivateEndpointGroupInformationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties for a group information object. </param>
        /// <returns> A new <see cref="IotHub.IotHubPrivateEndpointGroupInformationData"/> instance for mocking. </returns>
        public static IotHubPrivateEndpointGroupInformationData IotHubPrivateEndpointGroupInformationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IotHubPrivateEndpointGroupInformationProperties properties = null)
        {
            return new IotHubPrivateEndpointGroupInformationData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of IotHubPrivateEndpointGroupInformationProperties. </summary>
        /// <param name="groupId"> The group id. </param>
        /// <param name="requiredMembers"> The required members for a specific group id. </param>
        /// <param name="requiredDnsZoneNames"> The required DNS zones for a specific group id. </param>
        /// <returns> A new <see cref="Models.IotHubPrivateEndpointGroupInformationProperties"/> instance for mocking. </returns>
        public static IotHubPrivateEndpointGroupInformationProperties IotHubPrivateEndpointGroupInformationProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredDnsZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredDnsZoneNames ??= new List<string>();

            return new IotHubPrivateEndpointGroupInformationProperties(groupId, requiredMembers?.ToList(), requiredDnsZoneNames?.ToList());
        }
    }
}
