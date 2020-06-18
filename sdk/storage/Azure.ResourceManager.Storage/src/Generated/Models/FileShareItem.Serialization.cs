// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class FileShareItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (LastModifiedTime != null)
            {
                writer.WritePropertyName("lastModifiedTime");
                writer.WriteStringValue(LastModifiedTime.Value, "O");
            }
            if (Metadata != null)
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (ShareQuota != null)
            {
                writer.WritePropertyName("shareQuota");
                writer.WriteNumberValue(ShareQuota.Value);
            }
            if (EnabledProtocols != null)
            {
                writer.WritePropertyName("enabledProtocols");
                writer.WriteStringValue(EnabledProtocols.Value.ToString());
            }
            if (RootSquash != null)
            {
                writer.WritePropertyName("rootSquash");
                writer.WriteStringValue(RootSquash.Value.ToString());
            }
            if (Version != null)
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Deleted != null)
            {
                writer.WritePropertyName("deleted");
                writer.WriteBooleanValue(Deleted.Value);
            }
            if (DeletedTime != null)
            {
                writer.WritePropertyName("deletedTime");
                writer.WriteStringValue(DeletedTime.Value, "O");
            }
            if (RemainingRetentionDays != null)
            {
                writer.WritePropertyName("remainingRetentionDays");
                writer.WriteNumberValue(RemainingRetentionDays.Value);
            }
            if (AccessTier != null)
            {
                writer.WritePropertyName("accessTier");
                writer.WriteStringValue(AccessTier.Value.ToString());
            }
            if (AccessTierChangeTime != null)
            {
                writer.WritePropertyName("accessTierChangeTime");
                writer.WriteStringValue(AccessTierChangeTime.Value, "O");
            }
            if (AccessTierStatus != null)
            {
                writer.WritePropertyName("accessTierStatus");
                writer.WriteStringValue(AccessTierStatus);
            }
            if (ShareUsageBytes != null)
            {
                writer.WritePropertyName("shareUsageBytes");
                writer.WriteNumberValue(ShareUsageBytes.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FileShareItem DeserializeFileShareItem(JsonElement element)
        {
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            DateTimeOffset? lastModifiedTime = default;
            IDictionary<string, string> metadata = default;
            int? shareQuota = default;
            EnabledProtocols? enabledProtocols = default;
            RootSquashType? rootSquash = default;
            string version = default;
            bool? deleted = default;
            DateTimeOffset? deletedTime = default;
            int? remainingRetentionDays = default;
            ShareAccessTier? accessTier = default;
            DateTimeOffset? accessTierChangeTime = default;
            string accessTierStatus = default;
            long? shareUsageBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("lastModifiedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetString());
                                }
                            }
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("shareQuota"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shareQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabledProtocols"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledProtocols = new EnabledProtocols(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rootSquash"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rootSquash = new RootSquashType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleted"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("deletedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deletedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("remainingRetentionDays"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remainingRetentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("accessTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessTier = new ShareAccessTier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accessTierChangeTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessTierChangeTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessTierStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessTierStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("shareUsageBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shareUsageBytes = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FileShareItem(id, name, type, etag, lastModifiedTime, metadata, shareQuota, enabledProtocols, rootSquash, version, deleted, deletedTime, remainingRetentionDays, accessTier, accessTierChangeTime, accessTierStatus, shareUsageBytes);
        }
    }
}