// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.iosUpdateDeviceStatus&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.iosUpdateDeviceStatus&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "IosUpdateDeviceStatusObject", DefaultParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus")]
    [ODataType("microsoft.graph.iosUpdateDeviceStatus")]
    public class New_IosUpdateDeviceStatusObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;installStatus&quot; property, of type &quot;microsoft.graph.iosUpdatesInstallStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">The installation status of the policy report.</para>
        ///     <para type="description">
        ///          Valid values: &apos;success&apos;, &apos;available&apos;, &apos;idle&apos;, &apos;unknown&apos;, &apos;downloading&apos;, &apos;downloadFailed&apos;, &apos;downloadRequiresComputer&apos;, &apos;downloadInsufficientSpace&apos;, &apos;downloadInsufficientPower&apos;, &apos;downloadInsufficientNetwork&apos;, &apos;installing&apos;, &apos;installInsufficientSpace&apos;, &apos;installInsufficientPower&apos;, &apos;installPhoneCallInProgress&apos;, &apos;installFailed&apos;, &apos;notSupportedOperation&apos;, &apos;sharedDeviceUserLoggedInError&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.iosUpdatesInstallStatus")]
        [Selectable]
        [ValidateSet(@"success", @"available", @"idle", @"unknown", @"downloading", @"downloadFailed", @"downloadRequiresComputer", @"downloadInsufficientSpace", @"downloadInsufficientPower", @"downloadInsufficientNetwork", @"installing", @"installInsufficientSpace", @"installInsufficientPower", @"installPhoneCallInProgress", @"installFailed", @"notSupportedOperation", @"sharedDeviceUserLoggedInError")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;installStatus&quot; property, of type &quot;microsoft.graph.iosUpdatesInstallStatus&quot;.")]
        public System.String installStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">The device version that is being reported.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">The device id that is being reported.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">The User id that is being reported.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">Device name of the DevicePolicyStatus.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">Compliance status of the policy report.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">Last modified date time of the policy report.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastReportedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosUpdateDeviceStatus&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosUpdateDeviceStatus", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }
    }
}