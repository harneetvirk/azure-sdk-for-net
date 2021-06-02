// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class DatasetExportSummary : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("format");
            writer.WriteStringValue(Format.ToString());
            writer.WriteEndObject();
        }

        internal static DatasetExportSummary DeserializeDatasetExportSummary(JsonElement element)
        {
            Optional<string> labeledAssetName = default;
            ExportFormatType format = default;
            Optional<string> labelingJobId = default;
            Optional<long> exportedRowCount = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("labeledAssetName"))
                {
                    labeledAssetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("format"))
                {
                    format = new ExportFormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labelingJobId"))
                {
                    labelingJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exportedRowCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exportedRowCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("startTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DatasetExportSummary(format, labelingJobId.Value, Optional.ToNullable(exportedRowCount), Optional.ToNullable(startTimeUtc), Optional.ToNullable(endTimeUtc), labeledAssetName.Value);
        }
    }
}
