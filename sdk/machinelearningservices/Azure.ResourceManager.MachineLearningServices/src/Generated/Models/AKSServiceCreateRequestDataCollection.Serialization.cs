// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class AKSServiceCreateRequestDataCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EventHubEnabled))
            {
                writer.WritePropertyName("eventHubEnabled");
                writer.WriteBooleanValue(EventHubEnabled.Value);
            }
            if (Optional.IsDefined(StorageEnabled))
            {
                writer.WritePropertyName("storageEnabled");
                writer.WriteBooleanValue(StorageEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static AKSServiceCreateRequestDataCollection DeserializeAKSServiceCreateRequestDataCollection(JsonElement element)
        {
            Optional<bool> eventHubEnabled = default;
            Optional<bool> storageEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHubEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eventHubEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AKSServiceCreateRequestDataCollection(Optional.ToNullable(eventHubEnabled), Optional.ToNullable(storageEnabled));
        }
    }
}
