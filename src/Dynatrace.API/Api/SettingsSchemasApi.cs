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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Dynatrace.API.Client;
using Dynatrace.API.Model;

namespace Dynatrace.API.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ISettingsSchemasApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Lists available settings schemas | maturity&#x3D;EARLY_ADOPTER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SchemaList</returns>
        SchemaList GetAvailableSchemaDefinitions ();

        /// <summary>
        /// Lists available settings schemas | maturity&#x3D;EARLY_ADOPTER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SchemaList</returns>
        ApiResponse<SchemaList> GetAvailableSchemaDefinitionsWithHttpInfo ();
        /// <summary>
        /// Gets parameters of the specified settings schema | maturity&#x3D;EARLY_ADOPTER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">The ID of the required schema.</param>
        /// <param name="schemaVersion">The version of the required schema.  If not set, the most recent version is returned. (optional)</param>
        /// <returns>SchemaDefinitionRestDto</returns>
        SchemaDefinitionRestDto GetSchemaDefinition (string schemaId, string schemaVersion = null);

        /// <summary>
        /// Gets parameters of the specified settings schema | maturity&#x3D;EARLY_ADOPTER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">The ID of the required schema.</param>
        /// <param name="schemaVersion">The version of the required schema.  If not set, the most recent version is returned. (optional)</param>
        /// <returns>ApiResponse of SchemaDefinitionRestDto</returns>
        ApiResponse<SchemaDefinitionRestDto> GetSchemaDefinitionWithHttpInfo (string schemaId, string schemaVersion = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Lists available settings schemas | maturity&#x3D;EARLY_ADOPTER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SchemaList</returns>
        System.Threading.Tasks.Task<SchemaList> GetAvailableSchemaDefinitionsAsync ();

        /// <summary>
        /// Lists available settings schemas | maturity&#x3D;EARLY_ADOPTER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SchemaList)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaList>> GetAvailableSchemaDefinitionsAsyncWithHttpInfo ();
        /// <summary>
        /// Gets parameters of the specified settings schema | maturity&#x3D;EARLY_ADOPTER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">The ID of the required schema.</param>
        /// <param name="schemaVersion">The version of the required schema.  If not set, the most recent version is returned. (optional)</param>
        /// <returns>Task of SchemaDefinitionRestDto</returns>
        System.Threading.Tasks.Task<SchemaDefinitionRestDto> GetSchemaDefinitionAsync (string schemaId, string schemaVersion = null);

        /// <summary>
        /// Gets parameters of the specified settings schema | maturity&#x3D;EARLY_ADOPTER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">The ID of the required schema.</param>
        /// <param name="schemaVersion">The version of the required schema.  If not set, the most recent version is returned. (optional)</param>
        /// <returns>Task of ApiResponse (SchemaDefinitionRestDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaDefinitionRestDto>> GetSchemaDefinitionAsyncWithHttpInfo (string schemaId, string schemaVersion = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class SettingsSchemasApi : ISettingsSchemasApi
    {
        private Dynatrace.API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsSchemasApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsSchemasApi(String basePath)
        {
            this.Configuration = new Dynatrace.API.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Dynatrace.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsSchemasApi"/> class
        /// </summary>
        /// <returns></returns>
        public SettingsSchemasApi()
        {
            this.Configuration = Dynatrace.API.Client.Configuration.Default;

            ExceptionFactory = Dynatrace.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsSchemasApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SettingsSchemasApi(Dynatrace.API.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Dynatrace.API.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Dynatrace.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Dynatrace.API.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Dynatrace.API.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Lists available settings schemas | maturity&#x3D;EARLY_ADOPTER 
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SchemaList</returns>
        public SchemaList GetAvailableSchemaDefinitions ()
        {
             ApiResponse<SchemaList> localVarResponse = GetAvailableSchemaDefinitionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists available settings schemas | maturity&#x3D;EARLY_ADOPTER 
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SchemaList</returns>
        public ApiResponse< SchemaList > GetAvailableSchemaDefinitionsWithHttpInfo ()
        {

            var localVarPath = "/settings/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json; charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (Api-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAvailableSchemaDefinitions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SchemaList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SchemaList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaList)));
        }

        /// <summary>
        /// Lists available settings schemas | maturity&#x3D;EARLY_ADOPTER 
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SchemaList</returns>
        public async System.Threading.Tasks.Task<SchemaList> GetAvailableSchemaDefinitionsAsync ()
        {
             ApiResponse<SchemaList> localVarResponse = await GetAvailableSchemaDefinitionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists available settings schemas | maturity&#x3D;EARLY_ADOPTER 
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SchemaList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaList>> GetAvailableSchemaDefinitionsAsyncWithHttpInfo ()
        {

            var localVarPath = "/settings/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json; charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (Api-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAvailableSchemaDefinitions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SchemaList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SchemaList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaList)));
        }

        /// <summary>
        /// Gets parameters of the specified settings schema | maturity&#x3D;EARLY_ADOPTER 
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">The ID of the required schema.</param>
        /// <param name="schemaVersion">The version of the required schema.  If not set, the most recent version is returned. (optional)</param>
        /// <returns>SchemaDefinitionRestDto</returns>
        public SchemaDefinitionRestDto GetSchemaDefinition (string schemaId, string schemaVersion = null)
        {
             ApiResponse<SchemaDefinitionRestDto> localVarResponse = GetSchemaDefinitionWithHttpInfo(schemaId, schemaVersion);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets parameters of the specified settings schema | maturity&#x3D;EARLY_ADOPTER 
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">The ID of the required schema.</param>
        /// <param name="schemaVersion">The version of the required schema.  If not set, the most recent version is returned. (optional)</param>
        /// <returns>ApiResponse of SchemaDefinitionRestDto</returns>
        public ApiResponse< SchemaDefinitionRestDto > GetSchemaDefinitionWithHttpInfo (string schemaId, string schemaVersion = null)
        {
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling SettingsSchemasApi->GetSchemaDefinition");

            var localVarPath = "/settings/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json; charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            if (schemaVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "schemaVersion", schemaVersion)); // query parameter
            // authentication (Api-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSchemaDefinition", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SchemaDefinitionRestDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SchemaDefinitionRestDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaDefinitionRestDto)));
        }

        /// <summary>
        /// Gets parameters of the specified settings schema | maturity&#x3D;EARLY_ADOPTER 
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">The ID of the required schema.</param>
        /// <param name="schemaVersion">The version of the required schema.  If not set, the most recent version is returned. (optional)</param>
        /// <returns>Task of SchemaDefinitionRestDto</returns>
        public async System.Threading.Tasks.Task<SchemaDefinitionRestDto> GetSchemaDefinitionAsync (string schemaId, string schemaVersion = null)
        {
             ApiResponse<SchemaDefinitionRestDto> localVarResponse = await GetSchemaDefinitionAsyncWithHttpInfo(schemaId, schemaVersion);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets parameters of the specified settings schema | maturity&#x3D;EARLY_ADOPTER 
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">The ID of the required schema.</param>
        /// <param name="schemaVersion">The version of the required schema.  If not set, the most recent version is returned. (optional)</param>
        /// <returns>Task of ApiResponse (SchemaDefinitionRestDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaDefinitionRestDto>> GetSchemaDefinitionAsyncWithHttpInfo (string schemaId, string schemaVersion = null)
        {
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling SettingsSchemasApi->GetSchemaDefinition");

            var localVarPath = "/settings/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json; charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            if (schemaVersion != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "schemaVersion", schemaVersion)); // query parameter
            // authentication (Api-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSchemaDefinition", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SchemaDefinitionRestDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SchemaDefinitionRestDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaDefinitionRestDto)));
        }

    }
}
