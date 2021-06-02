// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class EnvironmentSpecificationVersion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Docker))
            {
                writer.WritePropertyName("docker");
                writer.WriteObjectValue(Docker);
            }
            if (Optional.IsDefined(CondaFile))
            {
                writer.WritePropertyName("condaFile");
                writer.WriteStringValue(CondaFile);
            }
            if (Optional.IsDefined(InferenceContainerProperties))
            {
                writer.WritePropertyName("inferenceContainerProperties");
                writer.WriteObjectValue(InferenceContainerProperties);
            }
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous");
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
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
            writer.WriteEndObject();
        }

        internal static EnvironmentSpecificationVersion DeserializeEnvironmentSpecificationVersion(JsonElement element)
        {
            Optional<EnvironmentSpecificationType> environmentSpecificationType = default;
            Optional<DockerSpecification> docker = default;
            Optional<string> condaFile = default;
            Optional<InferenceContainerProperties> inferenceContainerProperties = default;
            Optional<bool> isAnonymous = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IDictionary<string, string>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("environmentSpecificationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    environmentSpecificationType = new EnvironmentSpecificationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("docker"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    docker = DockerSpecification.DeserializeDockerSpecification(property.Value);
                    continue;
                }
                if (property.NameEquals("condaFile"))
                {
                    condaFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inferenceContainerProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    inferenceContainerProperties = InferenceContainerProperties.DeserializeInferenceContainerProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("isAnonymous"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
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
            }
            return new EnvironmentSpecificationVersion(Optional.ToNullable(environmentSpecificationType), docker.Value, condaFile.Value, inferenceContainerProperties.Value, Optional.ToNullable(isAnonymous), description.Value, Optional.ToDictionary(tags), Optional.ToDictionary(properties));
        }
    }
}
