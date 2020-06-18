// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ProcessorArchitecture != null)
            {
                writer.WritePropertyName("processorArchitecture");
                writer.WriteStringValue(ProcessorArchitecture.Value.ToString());
            }
            if (AuthenticationMethod != null)
            {
                writer.WritePropertyName("authenticationMethod");
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
            }
            if (RadiusServerAuthCertificate != null)
            {
                writer.WritePropertyName("radiusServerAuthCertificate");
                writer.WriteStringValue(RadiusServerAuthCertificate);
            }
            if (ClientRootCertificates != null)
            {
                writer.WritePropertyName("clientRootCertificates");
                writer.WriteStartArray();
                foreach (var item in ClientRootCertificates)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}