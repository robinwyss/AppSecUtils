/* 
 * Dynatrace Environment API
 *
 * Documentation of the Dynatrace Environment API v2. Resources here generally supersede those in v1. Migration of resources from v1 is in progress. If you miss a resource, consider using the Dynatrace Environment API v1. To read about use cases and examples, see [Dynatrace Documentation](https://dt-url.net/2u23k1k) .Notes about compatibility:* Operations marked as early adopter or preview may be changed in non-compatible ways, although we try to avoid this.* We may add new enum constants without incrementing the API version; thus, clients need to handle unknown enum constants gracefully.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Dynatrace.API.Client.SwaggerDateConverter;

namespace Dynatrace.API.Model
{
    /// <summary>
    /// Parameters of a new API token.
    /// </summary>
    [DataContract]
        public partial class ApiTokenCreate :  IEquatable<ApiTokenCreate>, IValidatableObject
    {
        /// <summary>
        /// Defines Scopes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ScopesEnum
        {
            /// <summary>
            /// Enum InstallerDownload for value: InstallerDownload
            /// </summary>
            [EnumMember(Value = "InstallerDownload")]
            InstallerDownload = 1,
            /// <summary>
            /// Enum DataExport for value: DataExport
            /// </summary>
            [EnumMember(Value = "DataExport")]
            DataExport = 2,
            /// <summary>
            /// Enum PluginUpload for value: PluginUpload
            /// </summary>
            [EnumMember(Value = "PluginUpload")]
            PluginUpload = 3,
            /// <summary>
            /// Enum SupportAlert for value: SupportAlert
            /// </summary>
            [EnumMember(Value = "SupportAlert")]
            SupportAlert = 4,
            /// <summary>
            /// Enum DcrumIntegration for value: DcrumIntegration
            /// </summary>
            [EnumMember(Value = "DcrumIntegration")]
            DcrumIntegration = 5,
            /// <summary>
            /// Enum AdvancedSyntheticIntegration for value: AdvancedSyntheticIntegration
            /// </summary>
            [EnumMember(Value = "AdvancedSyntheticIntegration")]
            AdvancedSyntheticIntegration = 6,
            /// <summary>
            /// Enum ExternalSyntheticIntegration for value: ExternalSyntheticIntegration
            /// </summary>
            [EnumMember(Value = "ExternalSyntheticIntegration")]
            ExternalSyntheticIntegration = 7,
            /// <summary>
            /// Enum AppMonIntegration for value: AppMonIntegration
            /// </summary>
            [EnumMember(Value = "AppMonIntegration")]
            AppMonIntegration = 8,
            /// <summary>
            /// Enum RumBrowserExtension for value: RumBrowserExtension
            /// </summary>
            [EnumMember(Value = "RumBrowserExtension")]
            RumBrowserExtension = 9,
            /// <summary>
            /// Enum LogExport for value: LogExport
            /// </summary>
            [EnumMember(Value = "LogExport")]
            LogExport = 10,
            /// <summary>
            /// Enum ReadConfig for value: ReadConfig
            /// </summary>
            [EnumMember(Value = "ReadConfig")]
            ReadConfig = 11,
            /// <summary>
            /// Enum WriteConfig for value: WriteConfig
            /// </summary>
            [EnumMember(Value = "WriteConfig")]
            WriteConfig = 12,
            /// <summary>
            /// Enum DTAQLAccess for value: DTAQLAccess
            /// </summary>
            [EnumMember(Value = "DTAQLAccess")]
            DTAQLAccess = 13,
            /// <summary>
            /// Enum UserSessionAnonymization for value: UserSessionAnonymization
            /// </summary>
            [EnumMember(Value = "UserSessionAnonymization")]
            UserSessionAnonymization = 14,
            /// <summary>
            /// Enum DataPrivacy for value: DataPrivacy
            /// </summary>
            [EnumMember(Value = "DataPrivacy")]
            DataPrivacy = 15,
            /// <summary>
            /// Enum CaptureRequestData for value: CaptureRequestData
            /// </summary>
            [EnumMember(Value = "CaptureRequestData")]
            CaptureRequestData = 16,
            /// <summary>
            /// Enum Davis for value: Davis
            /// </summary>
            [EnumMember(Value = "Davis")]
            Davis = 17,
            /// <summary>
            /// Enum DssFileManagement for value: DssFileManagement
            /// </summary>
            [EnumMember(Value = "DssFileManagement")]
            DssFileManagement = 18,
            /// <summary>
            /// Enum RumJavaScriptTagManagement for value: RumJavaScriptTagManagement
            /// </summary>
            [EnumMember(Value = "RumJavaScriptTagManagement")]
            RumJavaScriptTagManagement = 19,
            /// <summary>
            /// Enum TenantTokenManagement for value: TenantTokenManagement
            /// </summary>
            [EnumMember(Value = "TenantTokenManagement")]
            TenantTokenManagement = 20,
            /// <summary>
            /// Enum ActiveGateCertManagement for value: ActiveGateCertManagement
            /// </summary>
            [EnumMember(Value = "ActiveGateCertManagement")]
            ActiveGateCertManagement = 21,
            /// <summary>
            /// Enum RestRequestForwarding for value: RestRequestForwarding
            /// </summary>
            [EnumMember(Value = "RestRequestForwarding")]
            RestRequestForwarding = 22,
            /// <summary>
            /// Enum ReadSyntheticData for value: ReadSyntheticData
            /// </summary>
            [EnumMember(Value = "ReadSyntheticData")]
            ReadSyntheticData = 23,
            /// <summary>
            /// Enum DataImport for value: DataImport
            /// </summary>
            [EnumMember(Value = "DataImport")]
            DataImport = 24,
            /// <summary>
            /// Enum AuditLogsRead for value: auditLogs.read
            /// </summary>
            [EnumMember(Value = "auditLogs.read")]
            AuditLogsRead = 25,
            /// <summary>
            /// Enum MetricsRead for value: metrics.read
            /// </summary>
            [EnumMember(Value = "metrics.read")]
            MetricsRead = 26,
            /// <summary>
            /// Enum MetricsWrite for value: metrics.write
            /// </summary>
            [EnumMember(Value = "metrics.write")]
            MetricsWrite = 27,
            /// <summary>
            /// Enum EntitiesRead for value: entities.read
            /// </summary>
            [EnumMember(Value = "entities.read")]
            EntitiesRead = 28,
            /// <summary>
            /// Enum EntitiesWrite for value: entities.write
            /// </summary>
            [EnumMember(Value = "entities.write")]
            EntitiesWrite = 29,
            /// <summary>
            /// Enum ProblemsRead for value: problems.read
            /// </summary>
            [EnumMember(Value = "problems.read")]
            ProblemsRead = 30,
            /// <summary>
            /// Enum ProblemsWrite for value: problems.write
            /// </summary>
            [EnumMember(Value = "problems.write")]
            ProblemsWrite = 31,
            /// <summary>
            /// Enum NetworkZonesRead for value: networkZones.read
            /// </summary>
            [EnumMember(Value = "networkZones.read")]
            NetworkZonesRead = 32,
            /// <summary>
            /// Enum NetworkZonesWrite for value: networkZones.write
            /// </summary>
            [EnumMember(Value = "networkZones.write")]
            NetworkZonesWrite = 33,
            /// <summary>
            /// Enum ActiveGatesRead for value: activeGates.read
            /// </summary>
            [EnumMember(Value = "activeGates.read")]
            ActiveGatesRead = 34,
            /// <summary>
            /// Enum ActiveGatesWrite for value: activeGates.write
            /// </summary>
            [EnumMember(Value = "activeGates.write")]
            ActiveGatesWrite = 35,
            /// <summary>
            /// Enum CredentialVaultRead for value: credentialVault.read
            /// </summary>
            [EnumMember(Value = "credentialVault.read")]
            CredentialVaultRead = 36,
            /// <summary>
            /// Enum CredentialVaultWrite for value: credentialVault.write
            /// </summary>
            [EnumMember(Value = "credentialVault.write")]
            CredentialVaultWrite = 37,
            /// <summary>
            /// Enum ExtensionsRead for value: extensions.read
            /// </summary>
            [EnumMember(Value = "extensions.read")]
            ExtensionsRead = 38,
            /// <summary>
            /// Enum ExtensionsWrite for value: extensions.write
            /// </summary>
            [EnumMember(Value = "extensions.write")]
            ExtensionsWrite = 39,
            /// <summary>
            /// Enum ExtensionConfigurationsRead for value: extensionConfigurations.read
            /// </summary>
            [EnumMember(Value = "extensionConfigurations.read")]
            ExtensionConfigurationsRead = 40,
            /// <summary>
            /// Enum ExtensionConfigurationsWrite for value: extensionConfigurations.write
            /// </summary>
            [EnumMember(Value = "extensionConfigurations.write")]
            ExtensionConfigurationsWrite = 41,
            /// <summary>
            /// Enum ExtensionEnvironmentRead for value: extensionEnvironment.read
            /// </summary>
            [EnumMember(Value = "extensionEnvironment.read")]
            ExtensionEnvironmentRead = 42,
            /// <summary>
            /// Enum ExtensionEnvironmentWrite for value: extensionEnvironment.write
            /// </summary>
            [EnumMember(Value = "extensionEnvironment.write")]
            ExtensionEnvironmentWrite = 43,
            /// <summary>
            /// Enum MetricsIngest for value: metrics.ingest
            /// </summary>
            [EnumMember(Value = "metrics.ingest")]
            MetricsIngest = 44,
            /// <summary>
            /// Enum SecurityProblemsRead for value: securityProblems.read
            /// </summary>
            [EnumMember(Value = "securityProblems.read")]
            SecurityProblemsRead = 45,
            /// <summary>
            /// Enum SecurityProblemsWrite for value: securityProblems.write
            /// </summary>
            [EnumMember(Value = "securityProblems.write")]
            SecurityProblemsWrite = 46,
            /// <summary>
            /// Enum SyntheticLocationsRead for value: syntheticLocations.read
            /// </summary>
            [EnumMember(Value = "syntheticLocations.read")]
            SyntheticLocationsRead = 47,
            /// <summary>
            /// Enum SyntheticLocationsWrite for value: syntheticLocations.write
            /// </summary>
            [EnumMember(Value = "syntheticLocations.write")]
            SyntheticLocationsWrite = 48,
            /// <summary>
            /// Enum SettingsRead for value: settings.read
            /// </summary>
            [EnumMember(Value = "settings.read")]
            SettingsRead = 49,
            /// <summary>
            /// Enum SettingsWrite for value: settings.write
            /// </summary>
            [EnumMember(Value = "settings.write")]
            SettingsWrite = 50,
            /// <summary>
            /// Enum TenantTokenRotationWrite for value: tenantTokenRotation.write
            /// </summary>
            [EnumMember(Value = "tenantTokenRotation.write")]
            TenantTokenRotationWrite = 51,
            /// <summary>
            /// Enum SloRead for value: slo.read
            /// </summary>
            [EnumMember(Value = "slo.read")]
            SloRead = 52,
            /// <summary>
            /// Enum SloWrite for value: slo.write
            /// </summary>
            [EnumMember(Value = "slo.write")]
            SloWrite = 53,
            /// <summary>
            /// Enum ReleasesRead for value: releases.read
            /// </summary>
            [EnumMember(Value = "releases.read")]
            ReleasesRead = 54,
            /// <summary>
            /// Enum ApiTokensRead for value: apiTokens.read
            /// </summary>
            [EnumMember(Value = "apiTokens.read")]
            ApiTokensRead = 55,
            /// <summary>
            /// Enum ApiTokensWrite for value: apiTokens.write
            /// </summary>
            [EnumMember(Value = "apiTokens.write")]
            ApiTokensWrite = 56,
            /// <summary>
            /// Enum LogsRead for value: logs.read
            /// </summary>
            [EnumMember(Value = "logs.read")]
            LogsRead = 57,
            /// <summary>
            /// Enum LogsIngest for value: logs.ingest
            /// </summary>
            [EnumMember(Value = "logs.ingest")]
            LogsIngest = 58        }
        /// <summary>
        /// A list of the scopes to be assigned to the token.* &#x60;InstallerDownload&#x60;: PaaS integration - Installer download. * &#x60;DataExport&#x60;: Access problem and event feed, metrics, and topology. * &#x60;PluginUpload&#x60;: Upload Extension. * &#x60;SupportAlert&#x60;: PaaS integration - Support alert. * &#x60;DcrumIntegration&#x60;: Dynatrace module integration - NAM. * &#x60;AdvancedSyntheticIntegration&#x60;: Dynatrace module integration - Synthetic Classic. * &#x60;ExternalSyntheticIntegration&#x60;: Create and read synthetic monitors, locations, and nodes. * &#x60;AppMonIntegration&#x60;: Dynatrace module integration - AppMon. * &#x60;RumBrowserExtension&#x60;: RUM Browser Extension. * &#x60;LogExport&#x60;: Read logs. * &#x60;ReadConfig&#x60;: Read configuration. * &#x60;WriteConfig&#x60;: Write configuration. * &#x60;DTAQLAccess&#x60;: User sessions. * &#x60;UserSessionAnonymization&#x60;: Anonymize user session data for data privacy reasons. * &#x60;DataPrivacy&#x60;: Change data privacy settings. * &#x60;CaptureRequestData&#x60;: Capture request data. * &#x60;Davis&#x60;: Dynatrace module integration - Davis. * &#x60;DssFileManagement&#x60;: Mobile symbolication file management. * &#x60;RumJavaScriptTagManagement&#x60;: Real user monitoring JavaScript tag management. * &#x60;TenantTokenManagement&#x60;: Token management. * &#x60;ActiveGateCertManagement&#x60;: ActiveGate certificate management. * &#x60;RestRequestForwarding&#x60;: Fetch data from a remote environment. * &#x60;ReadSyntheticData&#x60;: Read synthetic monitors, locations, and nodes. * &#x60;DataImport&#x60;: Data ingest, e.g.: metrics and events. * &#x60;auditLogs.read&#x60;: Read audit logs. * &#x60;metrics.read&#x60;: Read metrics. * &#x60;metrics.write&#x60;: Write metrics. * &#x60;entities.read&#x60;: Read entities. * &#x60;entities.write&#x60;: Write entities. * &#x60;problems.read&#x60;: Read problems. * &#x60;problems.write&#x60;: Write problems. * &#x60;networkZones.read&#x60;: Read network zones. * &#x60;networkZones.write&#x60;: Write network zones. * &#x60;activeGates.read&#x60;: Read ActiveGates. * &#x60;activeGates.write&#x60;: Write ActiveGates. * &#x60;credentialVault.read&#x60;: Read credential vault entries. * &#x60;credentialVault.write&#x60;: Write credential vault entries. * &#x60;extensions.read&#x60;: Read extensions. * &#x60;extensions.write&#x60;: Write extensions. * &#x60;extensionConfigurations.read&#x60;: Read extension monitoring configurations. * &#x60;extensionConfigurations.write&#x60;: Write extension monitoring configurations. * &#x60;extensionEnvironment.read&#x60;: Read extension environment configurations. * &#x60;extensionEnvironment.write&#x60;: Write extension environment configurations. * &#x60;metrics.ingest&#x60;: Ingest metrics. * &#x60;securityProblems.read&#x60;: Read security problems. * &#x60;securityProblems.write&#x60;: Write security problems. * &#x60;syntheticLocations.read&#x60;: Read synthetic locations. * &#x60;syntheticLocations.write&#x60;: Write synthetic locations. * &#x60;settings.read&#x60;: Read settings. * &#x60;settings.write&#x60;: Write settings. * &#x60;tenantTokenRotation.write&#x60;: Tenant token rotation. * &#x60;slo.read&#x60;: Read SLO. * &#x60;slo.write&#x60;: Write SLO. * &#x60;releases.read&#x60;: Read releases. * &#x60;apiTokens.read&#x60;: Read API tokens. * &#x60;apiTokens.write&#x60;: Write API tokens. * &#x60;logs.read&#x60;: Read logs. * &#x60;logs.ingest&#x60;: Ingest logs. 
        /// </summary>
        /// <value>A list of the scopes to be assigned to the token.* &#x60;InstallerDownload&#x60;: PaaS integration - Installer download. * &#x60;DataExport&#x60;: Access problem and event feed, metrics, and topology. * &#x60;PluginUpload&#x60;: Upload Extension. * &#x60;SupportAlert&#x60;: PaaS integration - Support alert. * &#x60;DcrumIntegration&#x60;: Dynatrace module integration - NAM. * &#x60;AdvancedSyntheticIntegration&#x60;: Dynatrace module integration - Synthetic Classic. * &#x60;ExternalSyntheticIntegration&#x60;: Create and read synthetic monitors, locations, and nodes. * &#x60;AppMonIntegration&#x60;: Dynatrace module integration - AppMon. * &#x60;RumBrowserExtension&#x60;: RUM Browser Extension. * &#x60;LogExport&#x60;: Read logs. * &#x60;ReadConfig&#x60;: Read configuration. * &#x60;WriteConfig&#x60;: Write configuration. * &#x60;DTAQLAccess&#x60;: User sessions. * &#x60;UserSessionAnonymization&#x60;: Anonymize user session data for data privacy reasons. * &#x60;DataPrivacy&#x60;: Change data privacy settings. * &#x60;CaptureRequestData&#x60;: Capture request data. * &#x60;Davis&#x60;: Dynatrace module integration - Davis. * &#x60;DssFileManagement&#x60;: Mobile symbolication file management. * &#x60;RumJavaScriptTagManagement&#x60;: Real user monitoring JavaScript tag management. * &#x60;TenantTokenManagement&#x60;: Token management. * &#x60;ActiveGateCertManagement&#x60;: ActiveGate certificate management. * &#x60;RestRequestForwarding&#x60;: Fetch data from a remote environment. * &#x60;ReadSyntheticData&#x60;: Read synthetic monitors, locations, and nodes. * &#x60;DataImport&#x60;: Data ingest, e.g.: metrics and events. * &#x60;auditLogs.read&#x60;: Read audit logs. * &#x60;metrics.read&#x60;: Read metrics. * &#x60;metrics.write&#x60;: Write metrics. * &#x60;entities.read&#x60;: Read entities. * &#x60;entities.write&#x60;: Write entities. * &#x60;problems.read&#x60;: Read problems. * &#x60;problems.write&#x60;: Write problems. * &#x60;networkZones.read&#x60;: Read network zones. * &#x60;networkZones.write&#x60;: Write network zones. * &#x60;activeGates.read&#x60;: Read ActiveGates. * &#x60;activeGates.write&#x60;: Write ActiveGates. * &#x60;credentialVault.read&#x60;: Read credential vault entries. * &#x60;credentialVault.write&#x60;: Write credential vault entries. * &#x60;extensions.read&#x60;: Read extensions. * &#x60;extensions.write&#x60;: Write extensions. * &#x60;extensionConfigurations.read&#x60;: Read extension monitoring configurations. * &#x60;extensionConfigurations.write&#x60;: Write extension monitoring configurations. * &#x60;extensionEnvironment.read&#x60;: Read extension environment configurations. * &#x60;extensionEnvironment.write&#x60;: Write extension environment configurations. * &#x60;metrics.ingest&#x60;: Ingest metrics. * &#x60;securityProblems.read&#x60;: Read security problems. * &#x60;securityProblems.write&#x60;: Write security problems. * &#x60;syntheticLocations.read&#x60;: Read synthetic locations. * &#x60;syntheticLocations.write&#x60;: Write synthetic locations. * &#x60;settings.read&#x60;: Read settings. * &#x60;settings.write&#x60;: Write settings. * &#x60;tenantTokenRotation.write&#x60;: Tenant token rotation. * &#x60;slo.read&#x60;: Read SLO. * &#x60;slo.write&#x60;: Write SLO. * &#x60;releases.read&#x60;: Read releases. * &#x60;apiTokens.read&#x60;: Read API tokens. * &#x60;apiTokens.write&#x60;: Write API tokens. * &#x60;logs.read&#x60;: Read logs. * &#x60;logs.ingest&#x60;: Ingest logs. </value>
        [DataMember(Name="scopes", EmitDefaultValue=false)]
        public List<ScopesEnum> Scopes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenCreate" /> class.
        /// </summary>
        /// <param name="personalAccessToken">The token is a personal access token (&#x60;true&#x60;) or an API token (&#x60;false&#x60;).  Personal access tokens are tied to the permissions of their owner..</param>
        /// <param name="expirationDate">The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. * Human-readable format of &#x60;2021-01-25T05:57:01.123+01:00&#x60;. If no time zone is specified, UTC is used. You can use a space character instead of the &#x60;T&#x60;. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The format is &#x60;now-NU/A&#x60;, where &#x60;N&#x60; is the amount of time, &#x60;U&#x60; is the unit of time, and &#x60;A&#x60; is an alignment. The alignment rounds all the smaller values to the nearest zero in the past. For example, &#x60;now-1y/w&#x60; is one year back, aligned by a week. You can also specify relative timeframe without an alignment: &#x60;now-NU&#x60;. Supported time units for the relative timeframe are:    * &#x60;m&#x60;: minutes    * &#x60;h&#x60;: hours    * &#x60;d&#x60;: days    * &#x60;w&#x60;: weeks    * &#x60;M&#x60;: months    * &#x60;y&#x60;: years .</param>
        /// <param name="scopes">A list of the scopes to be assigned to the token.* &#x60;InstallerDownload&#x60;: PaaS integration - Installer download. * &#x60;DataExport&#x60;: Access problem and event feed, metrics, and topology. * &#x60;PluginUpload&#x60;: Upload Extension. * &#x60;SupportAlert&#x60;: PaaS integration - Support alert. * &#x60;DcrumIntegration&#x60;: Dynatrace module integration - NAM. * &#x60;AdvancedSyntheticIntegration&#x60;: Dynatrace module integration - Synthetic Classic. * &#x60;ExternalSyntheticIntegration&#x60;: Create and read synthetic monitors, locations, and nodes. * &#x60;AppMonIntegration&#x60;: Dynatrace module integration - AppMon. * &#x60;RumBrowserExtension&#x60;: RUM Browser Extension. * &#x60;LogExport&#x60;: Read logs. * &#x60;ReadConfig&#x60;: Read configuration. * &#x60;WriteConfig&#x60;: Write configuration. * &#x60;DTAQLAccess&#x60;: User sessions. * &#x60;UserSessionAnonymization&#x60;: Anonymize user session data for data privacy reasons. * &#x60;DataPrivacy&#x60;: Change data privacy settings. * &#x60;CaptureRequestData&#x60;: Capture request data. * &#x60;Davis&#x60;: Dynatrace module integration - Davis. * &#x60;DssFileManagement&#x60;: Mobile symbolication file management. * &#x60;RumJavaScriptTagManagement&#x60;: Real user monitoring JavaScript tag management. * &#x60;TenantTokenManagement&#x60;: Token management. * &#x60;ActiveGateCertManagement&#x60;: ActiveGate certificate management. * &#x60;RestRequestForwarding&#x60;: Fetch data from a remote environment. * &#x60;ReadSyntheticData&#x60;: Read synthetic monitors, locations, and nodes. * &#x60;DataImport&#x60;: Data ingest, e.g.: metrics and events. * &#x60;auditLogs.read&#x60;: Read audit logs. * &#x60;metrics.read&#x60;: Read metrics. * &#x60;metrics.write&#x60;: Write metrics. * &#x60;entities.read&#x60;: Read entities. * &#x60;entities.write&#x60;: Write entities. * &#x60;problems.read&#x60;: Read problems. * &#x60;problems.write&#x60;: Write problems. * &#x60;networkZones.read&#x60;: Read network zones. * &#x60;networkZones.write&#x60;: Write network zones. * &#x60;activeGates.read&#x60;: Read ActiveGates. * &#x60;activeGates.write&#x60;: Write ActiveGates. * &#x60;credentialVault.read&#x60;: Read credential vault entries. * &#x60;credentialVault.write&#x60;: Write credential vault entries. * &#x60;extensions.read&#x60;: Read extensions. * &#x60;extensions.write&#x60;: Write extensions. * &#x60;extensionConfigurations.read&#x60;: Read extension monitoring configurations. * &#x60;extensionConfigurations.write&#x60;: Write extension monitoring configurations. * &#x60;extensionEnvironment.read&#x60;: Read extension environment configurations. * &#x60;extensionEnvironment.write&#x60;: Write extension environment configurations. * &#x60;metrics.ingest&#x60;: Ingest metrics. * &#x60;securityProblems.read&#x60;: Read security problems. * &#x60;securityProblems.write&#x60;: Write security problems. * &#x60;syntheticLocations.read&#x60;: Read synthetic locations. * &#x60;syntheticLocations.write&#x60;: Write synthetic locations. * &#x60;settings.read&#x60;: Read settings. * &#x60;settings.write&#x60;: Write settings. * &#x60;tenantTokenRotation.write&#x60;: Tenant token rotation. * &#x60;slo.read&#x60;: Read SLO. * &#x60;slo.write&#x60;: Write SLO. * &#x60;releases.read&#x60;: Read releases. * &#x60;apiTokens.read&#x60;: Read API tokens. * &#x60;apiTokens.write&#x60;: Write API tokens. * &#x60;logs.read&#x60;: Read logs. * &#x60;logs.ingest&#x60;: Ingest logs.  (required).</param>
        /// <param name="name">The name of the token. (required).</param>
        public ApiTokenCreate(bool? personalAccessToken = default(bool?), string expirationDate = default(string), List<ScopesEnum> scopes = default(List<ScopesEnum>), string name = default(string))
        {
            // to ensure "scopes" is required (not null)
            if (scopes == null)
            {
                throw new InvalidDataException("scopes is a required property for ApiTokenCreate and cannot be null");
            }
            else
            {
                this.Scopes = scopes;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ApiTokenCreate and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.PersonalAccessToken = personalAccessToken;
            this.ExpirationDate = expirationDate;
        }
        
        /// <summary>
        /// The token is a personal access token (&#x60;true&#x60;) or an API token (&#x60;false&#x60;).  Personal access tokens are tied to the permissions of their owner.
        /// </summary>
        /// <value>The token is a personal access token (&#x60;true&#x60;) or an API token (&#x60;false&#x60;).  Personal access tokens are tied to the permissions of their owner.</value>
        [DataMember(Name="personalAccessToken", EmitDefaultValue=false)]
        public bool? PersonalAccessToken { get; set; }

        /// <summary>
        /// The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. * Human-readable format of &#x60;2021-01-25T05:57:01.123+01:00&#x60;. If no time zone is specified, UTC is used. You can use a space character instead of the &#x60;T&#x60;. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The format is &#x60;now-NU/A&#x60;, where &#x60;N&#x60; is the amount of time, &#x60;U&#x60; is the unit of time, and &#x60;A&#x60; is an alignment. The alignment rounds all the smaller values to the nearest zero in the past. For example, &#x60;now-1y/w&#x60; is one year back, aligned by a week. You can also specify relative timeframe without an alignment: &#x60;now-NU&#x60;. Supported time units for the relative timeframe are:    * &#x60;m&#x60;: minutes    * &#x60;h&#x60;: hours    * &#x60;d&#x60;: days    * &#x60;w&#x60;: weeks    * &#x60;M&#x60;: months    * &#x60;y&#x60;: years 
        /// </summary>
        /// <value>The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. * Human-readable format of &#x60;2021-01-25T05:57:01.123+01:00&#x60;. If no time zone is specified, UTC is used. You can use a space character instead of the &#x60;T&#x60;. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The format is &#x60;now-NU/A&#x60;, where &#x60;N&#x60; is the amount of time, &#x60;U&#x60; is the unit of time, and &#x60;A&#x60; is an alignment. The alignment rounds all the smaller values to the nearest zero in the past. For example, &#x60;now-1y/w&#x60; is one year back, aligned by a week. You can also specify relative timeframe without an alignment: &#x60;now-NU&#x60;. Supported time units for the relative timeframe are:    * &#x60;m&#x60;: minutes    * &#x60;h&#x60;: hours    * &#x60;d&#x60;: days    * &#x60;w&#x60;: weeks    * &#x60;M&#x60;: months    * &#x60;y&#x60;: years </value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }


        /// <summary>
        /// The name of the token.
        /// </summary>
        /// <value>The name of the token.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiTokenCreate {\n");
            sb.Append("  PersonalAccessToken: ").Append(PersonalAccessToken).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApiTokenCreate);
        }

        /// <summary>
        /// Returns true if ApiTokenCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiTokenCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiTokenCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PersonalAccessToken == input.PersonalAccessToken ||
                    (this.PersonalAccessToken != null &&
                    this.PersonalAccessToken.Equals(input.PersonalAccessToken))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    this.Scopes != null &&
                    input.Scopes != null &&
                    this.Scopes.SequenceEqual(input.Scopes)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PersonalAccessToken != null)
                    hashCode = hashCode * 59 + this.PersonalAccessToken.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.Scopes != null)
                    hashCode = hashCode * 59 + this.Scopes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
