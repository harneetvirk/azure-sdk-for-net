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
    [JsonConverter(typeof(MappingDataFlowConverter))]
    public partial class MappingDataFlow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Sources))
            {
                writer.WritePropertyName("sources");
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Sinks))
            {
                writer.WritePropertyName("sinks");
                writer.WriteStartArray();
                foreach (var item in Sinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Transformations))
            {
                writer.WritePropertyName("transformations");
                writer.WriteStartArray();
                foreach (var item in Transformations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script");
                writer.WriteStringValue(Script);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MappingDataFlow DeserializeMappingDataFlow(JsonElement element)
        {
            string type = default;
            Optional<string> description = default;
            Optional<IList<object>> annotations = default;
            Optional<DataFlowFolder> folder = default;
            Optional<IList<DataFlowSource>> sources = default;
            Optional<IList<DataFlowSink>> sinks = default;
            Optional<IList<Transformation>> transformations = default;
            Optional<string> script = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folder = DataFlowFolder.DeserializeDataFlowFolder(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataFlowSource> array = new List<DataFlowSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFlowSource.DeserializeDataFlowSource(item));
                            }
                            sources = array;
                            continue;
                        }
                        if (property0.NameEquals("sinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataFlowSink> array = new List<DataFlowSink>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFlowSink.DeserializeDataFlowSink(item));
                            }
                            sinks = array;
                            continue;
                        }
                        if (property0.NameEquals("transformations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Transformation> array = new List<Transformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Transformation.DeserializeTransformation(item));
                            }
                            transformations = array;
                            continue;
                        }
                        if (property0.NameEquals("script"))
                        {
                            script = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MappingDataFlow(type, description.Value, Optional.ToList(annotations), folder.Value, Optional.ToList(sources), Optional.ToList(sinks), Optional.ToList(transformations), script.Value);
        }

        internal partial class MappingDataFlowConverter : JsonConverter<MappingDataFlow>
        {
            public override void Write(Utf8JsonWriter writer, MappingDataFlow model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MappingDataFlow Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMappingDataFlow(document.RootElement);
            }
        }
    }
}
