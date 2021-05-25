/* 
 * Dynatrace Environment API
 *
 *  Documentation of the Dynatrace Environment API v2. Resources here generally supersede those in v1. Migration of resources from v1 is in progress.   If you miss a resource, consider using the Dynatrace Environment API v1. To read about use cases and examples, refer to the [help page](https://dt-url.net/2u23k1k) .  Notes about compatibility: * Operations marked as early adopter or preview may be changed in non-compatible ways, although we try to avoid this. * We may add new enum constants without incrementing the API version; thus, clients need to handle unknown enum constants gracefully.
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
        public interface IAccessTokensTenantTokensApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancels tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TenantTokenConfig</returns>
        TenantTokenConfig CancelRotation ();

        /// <summary>
        /// Cancels tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TenantTokenConfig</returns>
        ApiResponse<TenantTokenConfig> CancelRotationWithHttpInfo ();
        /// <summary>
        /// Finishes tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TenantTokenConfig</returns>
        TenantTokenConfig FinishRotation ();

        /// <summary>
        /// Finishes tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TenantTokenConfig</returns>
        ApiResponse<TenantTokenConfig> FinishRotationWithHttpInfo ();
        /// <summary>
        /// Starts tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TenantTokenConfig</returns>
        TenantTokenConfig StartRotation ();

        /// <summary>
        /// Starts tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TenantTokenConfig</returns>
        ApiResponse<TenantTokenConfig> StartRotationWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Cancels tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TenantTokenConfig</returns>
        System.Threading.Tasks.Task<TenantTokenConfig> CancelRotationAsync ();

        /// <summary>
        /// Cancels tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TenantTokenConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantTokenConfig>> CancelRotationAsyncWithHttpInfo ();
        /// <summary>
        /// Finishes tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TenantTokenConfig</returns>
        System.Threading.Tasks.Task<TenantTokenConfig> FinishRotationAsync ();

        /// <summary>
        /// Finishes tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TenantTokenConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantTokenConfig>> FinishRotationAsyncWithHttpInfo ();
        /// <summary>
        /// Starts tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TenantTokenConfig</returns>
        System.Threading.Tasks.Task<TenantTokenConfig> StartRotationAsync ();

        /// <summary>
        /// Starts tenant token rotation
        /// </summary>
        /// <remarks>
        /// To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </remarks>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TenantTokenConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantTokenConfig>> StartRotationAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class AccessTokensTenantTokensApi : IAccessTokensTenantTokensApi
    {
        private Dynatrace.API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokensTenantTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessTokensTenantTokensApi(String basePath)
        {
            this.Configuration = new Dynatrace.API.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Dynatrace.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokensTenantTokensApi"/> class
        /// </summary>
        /// <returns></returns>
        public AccessTokensTenantTokensApi()
        {
            this.Configuration = Dynatrace.API.Client.Configuration.Default;

            ExceptionFactory = Dynatrace.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokensTenantTokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccessTokensTenantTokensApi(Dynatrace.API.Client.Configuration configuration = null)
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
        /// Cancels tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TenantTokenConfig</returns>
        public TenantTokenConfig CancelRotation ()
        {
             ApiResponse<TenantTokenConfig> localVarResponse = CancelRotationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancels tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TenantTokenConfig</returns>
        public ApiResponse< TenantTokenConfig > CancelRotationWithHttpInfo ()
        {

            var localVarPath = "/tenantTokenRotation/cancel";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelRotation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantTokenConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TenantTokenConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantTokenConfig)));
        }

        /// <summary>
        /// Cancels tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TenantTokenConfig</returns>
        public async System.Threading.Tasks.Task<TenantTokenConfig> CancelRotationAsync ()
        {
             ApiResponse<TenantTokenConfig> localVarResponse = await CancelRotationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancels tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TenantTokenConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantTokenConfig>> CancelRotationAsyncWithHttpInfo ()
        {

            var localVarPath = "/tenantTokenRotation/cancel";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelRotation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantTokenConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TenantTokenConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantTokenConfig)));
        }

        /// <summary>
        /// Finishes tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TenantTokenConfig</returns>
        public TenantTokenConfig FinishRotation ()
        {
             ApiResponse<TenantTokenConfig> localVarResponse = FinishRotationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Finishes tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TenantTokenConfig</returns>
        public ApiResponse< TenantTokenConfig > FinishRotationWithHttpInfo ()
        {

            var localVarPath = "/tenantTokenRotation/finish";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FinishRotation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantTokenConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TenantTokenConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantTokenConfig)));
        }

        /// <summary>
        /// Finishes tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TenantTokenConfig</returns>
        public async System.Threading.Tasks.Task<TenantTokenConfig> FinishRotationAsync ()
        {
             ApiResponse<TenantTokenConfig> localVarResponse = await FinishRotationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Finishes tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TenantTokenConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantTokenConfig>> FinishRotationAsyncWithHttpInfo ()
        {

            var localVarPath = "/tenantTokenRotation/finish";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FinishRotation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantTokenConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TenantTokenConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantTokenConfig)));
        }

        /// <summary>
        /// Starts tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TenantTokenConfig</returns>
        public TenantTokenConfig StartRotation ()
        {
             ApiResponse<TenantTokenConfig> localVarResponse = StartRotationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Starts tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TenantTokenConfig</returns>
        public ApiResponse< TenantTokenConfig > StartRotationWithHttpInfo ()
        {

            var localVarPath = "/tenantTokenRotation/start";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("StartRotation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantTokenConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TenantTokenConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantTokenConfig)));
        }

        /// <summary>
        /// Starts tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TenantTokenConfig</returns>
        public async System.Threading.Tasks.Task<TenantTokenConfig> StartRotationAsync ()
        {
             ApiResponse<TenantTokenConfig> localVarResponse = await StartRotationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Starts tenant token rotation To learn how to rotate tokens, see the [Token rotation](https://dt-url.net/1543sf6) help page.
        /// </summary>
        /// <exception cref="Dynatrace.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TenantTokenConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantTokenConfig>> StartRotationAsyncWithHttpInfo ()
        {

            var localVarPath = "/tenantTokenRotation/start";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("StartRotation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantTokenConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TenantTokenConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantTokenConfig)));
        }

    }
}
