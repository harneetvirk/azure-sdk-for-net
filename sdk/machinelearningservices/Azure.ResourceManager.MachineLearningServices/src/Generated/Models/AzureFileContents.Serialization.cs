// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class AzureFileContents : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("accountName");
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("containerName");
            writer.WriteStringValue(ContainerName);
            writer.WritePropertyName("endpoint");
            writer.WriteStringValue(Endpoint);
            writer.WritePropertyName("protocol");
            writer.WriteStringValue(Protocol);
            writer.WritePropertyName("credentials");
            writer.WriteObjectValue(Credentials);
            writer.WritePropertyName("contentsType");
            writer.WriteStringValue(ContentsType.ToString());
            writer.WriteEndObject();
        }

        internal static AzureFileContents DeserializeAzureFileContents(JsonElement element)
        {
            string accountName = default;
            string containerName = default;
            string endpoint = default;
            string protocol = default;
            DatastoreCredentials credentials = default;
            ContentsType contentsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    credentials = DatastoreCredentials.DeserializeDatastoreCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("contentsType"))
                {
                    contentsType = new ContentsType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureFileContents(contentsType, accountName, containerName, endpoint, protocol, credentials);
        }
    }
}
