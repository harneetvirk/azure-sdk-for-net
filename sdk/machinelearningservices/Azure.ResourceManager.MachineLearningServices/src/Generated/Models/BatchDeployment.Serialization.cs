// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class BatchDeployment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Compute))
            {
                writer.WritePropertyName("compute");
                writer.WriteObjectValue(Compute);
            }
            if (Optional.IsDefined(ErrorThreshold))
            {
                writer.WritePropertyName("errorThreshold");
                writer.WriteNumberValue(ErrorThreshold.Value);
            }
            if (Optional.IsDefined(RetrySettings))
            {
                writer.WritePropertyName("retrySettings");
                writer.WriteObjectValue(RetrySettings);
            }
            if (Optional.IsCollectionDefined(PartitionKeys))
            {
                writer.WritePropertyName("partitionKeys");
                writer.WriteStartArray();
                foreach (var item in PartitionKeys)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MiniBatchSize))
            {
                writer.WritePropertyName("miniBatchSize");
                writer.WriteNumberValue(MiniBatchSize.Value);
            }
            if (Optional.IsDefined(LoggingLevel))
            {
                writer.WritePropertyName("loggingLevel");
                writer.WriteStringValue(LoggingLevel.Value.ToString());
            }
            if (Optional.IsDefined(OutputConfiguration))
            {
                writer.WritePropertyName("outputConfiguration");
                writer.WriteObjectValue(OutputConfiguration);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model");
                writer.WriteObjectValue(Model);
            }
            if (Optional.IsDefined(CodeConfiguration))
            {
                writer.WritePropertyName("codeConfiguration");
                writer.WriteObjectValue(CodeConfiguration);
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId");
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static BatchDeployment DeserializeBatchDeployment(JsonElement element)
        {
            Optional<ComputeConfiguration> compute = default;
            Optional<int> errorThreshold = default;
            Optional<BatchRetrySettings> retrySettings = default;
            Optional<IList<string>> partitionKeys = default;
            Optional<long> miniBatchSize = default;
            Optional<BatchLoggingLevel> loggingLevel = default;
            Optional<BatchOutputConfiguration> outputConfiguration = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<AssetReferenceBase> model = default;
            Optional<CodeConfiguration> codeConfiguration = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    compute = ComputeConfiguration.DeserializeComputeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("errorThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    errorThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("retrySettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retrySettings = BatchRetrySettings.DeserializeBatchRetrySettings(property.Value);
                    continue;
                }
                if (property.NameEquals("partitionKeys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    partitionKeys = array;
                    continue;
                }
                if (property.NameEquals("miniBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    miniBatchSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("loggingLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loggingLevel = new BatchLoggingLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    outputConfiguration = BatchOutputConfiguration.DeserializeBatchOutputConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
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
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("model"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    model = AssetReferenceBase.DeserializeAssetReferenceBase(property.Value);
                    continue;
                }
                if (property.NameEquals("codeConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    codeConfiguration = CodeConfiguration.DeserializeCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentId"))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"))
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
                    environmentVariables = dictionary;
                    continue;
                }
            }
            return new BatchDeployment(compute.Value, Optional.ToNullable(errorThreshold), retrySettings.Value, Optional.ToList(partitionKeys), Optional.ToNullable(miniBatchSize), Optional.ToNullable(loggingLevel), outputConfiguration.Value, description.Value, Optional.ToDictionary(properties), model.Value, codeConfiguration.Value, environmentId.Value, Optional.ToDictionary(environmentVariables));
        }
    }
}
