// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class AKSServiceResponseAutoScaler : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoscaleEnabled))
            {
                writer.WritePropertyName("autoscaleEnabled");
                writer.WriteBooleanValue(AutoscaleEnabled.Value);
            }
            if (Optional.IsDefined(MinReplicas))
            {
                writer.WritePropertyName("minReplicas");
                writer.WriteNumberValue(MinReplicas.Value);
            }
            if (Optional.IsDefined(MaxReplicas))
            {
                writer.WritePropertyName("maxReplicas");
                writer.WriteNumberValue(MaxReplicas.Value);
            }
            if (Optional.IsDefined(TargetUtilization))
            {
                writer.WritePropertyName("targetUtilization");
                writer.WriteNumberValue(TargetUtilization.Value);
            }
            if (Optional.IsDefined(RefreshPeriodInSeconds))
            {
                writer.WritePropertyName("refreshPeriodInSeconds");
                writer.WriteNumberValue(RefreshPeriodInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static AKSServiceResponseAutoScaler DeserializeAKSServiceResponseAutoScaler(JsonElement element)
        {
            Optional<bool> autoscaleEnabled = default;
            Optional<int> minReplicas = default;
            Optional<int> maxReplicas = default;
            Optional<int> targetUtilization = default;
            Optional<int> refreshPeriodInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoscaleEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoscaleEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minReplicas"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxReplicas"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetUtilization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetUtilization = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("refreshPeriodInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    refreshPeriodInSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new AKSServiceResponseAutoScaler(Optional.ToNullable(autoscaleEnabled), Optional.ToNullable(minReplicas), Optional.ToNullable(maxReplicas), Optional.ToNullable(targetUtilization), Optional.ToNullable(refreshPeriodInSeconds));
        }
    }
}
