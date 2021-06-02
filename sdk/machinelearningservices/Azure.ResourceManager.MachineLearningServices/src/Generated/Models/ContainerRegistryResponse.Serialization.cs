// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class ContainerRegistryResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address");
                writer.WriteStringValue(Address);
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryResponse DeserializeContainerRegistryResponse(JsonElement element)
        {
            Optional<string> address = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerRegistryResponse(address.Value);
        }
    }
}
