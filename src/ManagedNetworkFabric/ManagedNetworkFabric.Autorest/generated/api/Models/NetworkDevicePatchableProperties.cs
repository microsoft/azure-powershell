// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Network Device updatable properties.</summary>
    public partial class NetworkDevicePatchableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchableProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal
    {

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>The host name of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>
        /// Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Creates an new <see cref="NetworkDevicePatchableProperties" /> instance.</summary>
        public NetworkDevicePatchableProperties()
        {

        }
    }
    /// Network Device updatable properties.
    public partial interface INetworkDevicePatchableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable
    {
        /// <summary>The host name of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The host name of the device.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>
        /// Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }

    }
    /// Network Device updatable properties.
    internal partial interface INetworkDevicePatchablePropertiesInternal

    {
        /// <summary>The host name of the device.</summary>
        string HostName { get; set; }
        /// <summary>
        /// Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.
        /// </summary>
        string SerialNumber { get; set; }

    }
}