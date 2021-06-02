// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class ACIServiceResponseEncryptionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vaultBaseUrl");
            writer.WriteStringValue(VaultBaseUrl);
            writer.WritePropertyName("keyName");
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVersion");
            writer.WriteStringValue(KeyVersion);
            writer.WriteEndObject();
        }

        internal static ACIServiceResponseEncryptionProperties DeserializeACIServiceResponseEncryptionProperties(JsonElement element)
        {
            string vaultBaseUrl = default;
            string keyName = default;
            string keyVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultBaseUrl"))
                {
                    vaultBaseUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyName"))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ACIServiceResponseEncryptionProperties(vaultBaseUrl, keyName, keyVersion);
        }
    }
}
