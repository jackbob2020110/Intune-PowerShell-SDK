// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; objects in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection network learning summaries.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/windowsInformationProtectionNetworkLearningSummaries</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceManagement_WindowsInformationProtectionNetworkLearningSummaries", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionNetworkLearningSummaryODataType")]
    [ResourceReference]
    [Alias("Get-IntuneWindowsInformationProtectionNetworkLearningSummary")]
    public class Get_DeviceManagement_WindowsInformationProtectionNetworkLearningSummaries : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionNetworkLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Website url</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionNetworkLearningSummaries/{windowsInformationProtectionNetworkLearningSummaryId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object to the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection network learning summaries.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/windowsInformationProtectionNetworkLearningSummaries</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceManagement_WindowsInformationProtectionNetworkLearningSummaries", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionNetworkLearningSummaryODataType")]
    [ResourceReference]
    [Alias("New-IntuneWindowsInformationProtectionNetworkLearningSummary")]
    public class New_DeviceManagement_WindowsInformationProtectionNetworkLearningSummaries : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String windowsInformationProtectionNetworkLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Website url</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionNetworkLearningSummaries/{windowsInformationProtectionNetworkLearningSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection network learning summaries.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/windowsInformationProtectionNetworkLearningSummaries</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceManagement_WindowsInformationProtectionNetworkLearningSummaries", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionNetworkLearningSummaryODataType")]
    [Alias("Update-IntuneWindowsInformationProtectionNetworkLearningSummary")]
    public class Update_DeviceManagement_WindowsInformationProtectionNetworkLearningSummaries : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionNetworkLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Website url</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionNetworkLearningSummaries/{windowsInformationProtectionNetworkLearningSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object from the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection network learning summaries.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/windowsInformationProtectionNetworkLearningSummaries/windowsInformationProtectionNetworkLearningSummaryId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceManagement_WindowsInformationProtectionNetworkLearningSummaries", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionNetworkLearningSummaryODataType")]
    [Alias("Remove-IntuneWindowsInformationProtectionNetworkLearningSummary")]
    public class Remove_DeviceManagement_WindowsInformationProtectionNetworkLearningSummaries : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionNetworkLearningSummaryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionNetworkLearningSummaries/{windowsInformationProtectionNetworkLearningSummaryId}";
        }
    }
}