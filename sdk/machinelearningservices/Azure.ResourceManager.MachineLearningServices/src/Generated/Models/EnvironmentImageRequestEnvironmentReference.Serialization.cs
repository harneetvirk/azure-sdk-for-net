// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class EnvironmentImageRequestEnvironmentReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            writer.WriteEndObject();
        }

        internal static EnvironmentImageRequestEnvironmentReference DeserializeEnvironmentImageRequestEnvironmentReference(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new EnvironmentImageRequestEnvironmentReference(name.Value, version.Value);
        }
    }
}
