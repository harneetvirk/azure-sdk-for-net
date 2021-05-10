// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ActivityPolicyConverter))]
    public partial class ActivityPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteObjectValue(Timeout);
            }
            if (Optional.IsDefined(Retry))
            {
                writer.WritePropertyName("retry");
                writer.WriteObjectValue(Retry);
            }
            if (Optional.IsDefined(RetryIntervalInSeconds))
            {
                writer.WritePropertyName("retryIntervalInSeconds");
                writer.WriteNumberValue(RetryIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(SecureInput))
            {
                writer.WritePropertyName("secureInput");
                writer.WriteBooleanValue(SecureInput.Value);
            }
            if (Optional.IsDefined(SecureOutput))
            {
                writer.WritePropertyName("secureOutput");
                writer.WriteBooleanValue(SecureOutput.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ActivityPolicy DeserializeActivityPolicy(JsonElement element)
        {
            Optional<object> timeout = default;
            Optional<object> retry = default;
            Optional<int> retryIntervalInSeconds = default;
            Optional<bool> secureInput = default;
            Optional<bool> secureOutput = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("retry"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retry = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("retryIntervalInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retryIntervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("secureInput"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    secureInput = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("secureOutput"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    secureOutput = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ActivityPolicy(timeout.Value, retry.Value, Optional.ToNullable(retryIntervalInSeconds), Optional.ToNullable(secureInput), Optional.ToNullable(secureOutput), additionalProperties);
        }

        internal partial class ActivityPolicyConverter : JsonConverter<ActivityPolicy>
        {
            public override void Write(Utf8JsonWriter writer, ActivityPolicy model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ActivityPolicy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeActivityPolicy(document.RootElement);
            }
        }
    }
}
