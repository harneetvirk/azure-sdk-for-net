// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class ProbeSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FailureThreshold))
            {
                writer.WritePropertyName("failureThreshold");
                writer.WriteNumberValue(FailureThreshold.Value);
            }
            if (Optional.IsDefined(SuccessThreshold))
            {
                writer.WritePropertyName("successThreshold");
                writer.WriteNumberValue(SuccessThreshold.Value);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout.Value, "P");
            }
            if (Optional.IsDefined(Period))
            {
                writer.WritePropertyName("period");
                writer.WriteStringValue(Period.Value, "P");
            }
            if (Optional.IsDefined(InitialDelay))
            {
                writer.WritePropertyName("initialDelay");
                writer.WriteStringValue(InitialDelay.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static ProbeSettings DeserializeProbeSettings(JsonElement element)
        {
            Optional<int> failureThreshold = default;
            Optional<int> successThreshold = default;
            Optional<TimeSpan> timeout = default;
            Optional<TimeSpan> period = default;
            Optional<TimeSpan> initialDelay = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failureThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("successThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    successThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("period"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    period = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("initialDelay"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialDelay = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new ProbeSettings(Optional.ToNullable(failureThreshold), Optional.ToNullable(successThreshold), Optional.ToNullable(timeout), Optional.ToNullable(period), Optional.ToNullable(initialDelay));
        }
    }
}
