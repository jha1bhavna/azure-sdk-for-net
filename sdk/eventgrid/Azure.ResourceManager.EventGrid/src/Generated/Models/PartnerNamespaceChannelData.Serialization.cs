// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class PartnerNamespaceChannelData : IUtf8JsonSerializable, IJsonModel<PartnerNamespaceChannelData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerNamespaceChannelData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerNamespaceChannelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceChannelData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerNamespaceChannelData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ChannelType))
            {
                writer.WritePropertyName("channelType"u8);
                writer.WriteStringValue(ChannelType.Value.ToString());
            }
            if (Optional.IsDefined(PartnerTopicInfo))
            {
                writer.WritePropertyName("partnerTopicInfo"u8);
                writer.WriteObjectValue(PartnerTopicInfo);
            }
            if (Optional.IsDefined(PartnerDestinationInfo))
            {
                writer.WritePropertyName("partnerDestinationInfo"u8);
                writer.WriteObjectValue(PartnerDestinationInfo);
            }
            if (Optional.IsDefined(MessageForActivation))
            {
                writer.WritePropertyName("messageForActivation"u8);
                writer.WriteStringValue(MessageForActivation);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ReadinessState))
            {
                writer.WritePropertyName("readinessState"u8);
                writer.WriteStringValue(ReadinessState.Value.ToString());
            }
            if (Optional.IsDefined(ExpireOnIfNotActivated))
            {
                writer.WritePropertyName("expirationTimeIfNotActivatedUtc"u8);
                writer.WriteStringValue(ExpireOnIfNotActivated.Value, "O");
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        PartnerNamespaceChannelData IJsonModel<PartnerNamespaceChannelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceChannelData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerNamespaceChannelData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerNamespaceChannelData(document.RootElement, options);
        }

        internal static PartnerNamespaceChannelData DeserializePartnerNamespaceChannelData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<PartnerNamespaceChannelType> channelType = default;
            Optional<PartnerTopicInfo> partnerTopicInfo = default;
            Optional<PartnerDestinationInfo> partnerDestinationInfo = default;
            Optional<string> messageForActivation = default;
            Optional<PartnerNamespaceChannelProvisioningState> provisioningState = default;
            Optional<PartnerTopicReadinessState> readinessState = default;
            Optional<DateTimeOffset> expirationTimeIfNotActivatedUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("channelType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            channelType = new PartnerNamespaceChannelType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("partnerTopicInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerTopicInfo = PartnerTopicInfo.DeserializePartnerTopicInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("partnerDestinationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerDestinationInfo = PartnerDestinationInfo.DeserializePartnerDestinationInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("messageForActivation"u8))
                        {
                            messageForActivation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PartnerNamespaceChannelProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("readinessState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readinessState = new PartnerTopicReadinessState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expirationTimeIfNotActivatedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTimeIfNotActivatedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PartnerNamespaceChannelData(id, name, type, systemData.Value, Optional.ToNullable(channelType), partnerTopicInfo.Value, partnerDestinationInfo.Value, messageForActivation.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(readinessState), Optional.ToNullable(expirationTimeIfNotActivatedUtc), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PartnerNamespaceChannelData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceChannelData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartnerNamespaceChannelData)} does not support '{options.Format}' format.");
            }
        }

        PartnerNamespaceChannelData IPersistableModel<PartnerNamespaceChannelData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceChannelData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartnerNamespaceChannelData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerNamespaceChannelData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerNamespaceChannelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
