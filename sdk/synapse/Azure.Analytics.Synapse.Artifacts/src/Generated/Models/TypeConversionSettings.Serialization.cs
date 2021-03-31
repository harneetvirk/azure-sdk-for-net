// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TypeConversionSettingsConverter))]
    public partial class TypeConversionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowDataTruncation))
            {
                writer.WritePropertyName("allowDataTruncation");
                writer.WriteObjectValue(AllowDataTruncation);
            }
            if (Optional.IsDefined(TreatBooleanAsNumber))
            {
                writer.WritePropertyName("treatBooleanAsNumber");
                writer.WriteObjectValue(TreatBooleanAsNumber);
            }
            if (Optional.IsDefined(DateTimeFormat))
            {
                writer.WritePropertyName("dateTimeFormat");
                writer.WriteObjectValue(DateTimeFormat);
            }
            if (Optional.IsDefined(DateTimeOffsetFormat))
            {
                writer.WritePropertyName("dateTimeOffsetFormat");
                writer.WriteObjectValue(DateTimeOffsetFormat);
            }
            if (Optional.IsDefined(TimeSpanFormat))
            {
                writer.WritePropertyName("timeSpanFormat");
                writer.WriteObjectValue(TimeSpanFormat);
            }
            if (Optional.IsDefined(Culture))
            {
                writer.WritePropertyName("culture");
                writer.WriteObjectValue(Culture);
            }
            writer.WriteEndObject();
        }

        internal static TypeConversionSettings DeserializeTypeConversionSettings(JsonElement element)
        {
            Optional<object> allowDataTruncation = default;
            Optional<object> treatBooleanAsNumber = default;
            Optional<object> dateTimeFormat = default;
            Optional<object> dateTimeOffsetFormat = default;
            Optional<object> timeSpanFormat = default;
            Optional<object> culture = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowDataTruncation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowDataTruncation = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("treatBooleanAsNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    treatBooleanAsNumber = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("dateTimeFormat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTimeFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("dateTimeOffsetFormat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTimeOffsetFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("timeSpanFormat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeSpanFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("culture"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    culture = property.Value.GetObject();
                    continue;
                }
            }
            return new TypeConversionSettings(allowDataTruncation.Value, treatBooleanAsNumber.Value, dateTimeFormat.Value, dateTimeOffsetFormat.Value, timeSpanFormat.Value, culture.Value);
        }

        internal partial class TypeConversionSettingsConverter : JsonConverter<TypeConversionSettings>
        {
            public override void Write(Utf8JsonWriter writer, TypeConversionSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeConversionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeConversionSettings(document.RootElement);
            }
        }
    }
}
