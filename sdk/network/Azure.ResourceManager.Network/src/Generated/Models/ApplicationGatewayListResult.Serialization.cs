// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ApplicationGatewayListResult
    {
        internal static ApplicationGatewayListResult DeserializeApplicationGatewayListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ApplicationGateway>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ApplicationGateway> array = new List<ApplicationGateway>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGateway.DeserializeApplicationGateway(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationGatewayListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
