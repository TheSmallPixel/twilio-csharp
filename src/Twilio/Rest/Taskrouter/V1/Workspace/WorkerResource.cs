/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Taskrouter.V1.Workspace
{
    public class WorkerResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateWorkerOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workers";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static WorkerResource Create(CreateWorkerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<WorkerResource> CreateAsync(CreateWorkerOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Worker belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new Worker. It can be up to 64 characters long. </param>
        /// <param name="activitySid"> The SID of a valid Activity that will describe the new Worker's initial state. See [Activities](https://www.twilio.com/docs/taskrouter/api/activity) for more information. If not provided, the new Worker's initial state is the `default_activity_sid` configured on the Workspace. </param>
        /// <param name="attributes"> A valid JSON string that describes the new Worker. For example: `{ \\\"email\\\": \\\"Bob@example.com\\\", \\\"phone\\\": \\\"+5095551234\\\" }`. This data is passed to the `assignment_callback_url` when TaskRouter assigns a Task to the Worker. Defaults to {}. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static WorkerResource Create(
                                          string pathWorkspaceSid,
                                          string friendlyName,
                                          string activitySid = null,
                                          string attributes = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateWorkerOptions(pathWorkspaceSid, friendlyName){  ActivitySid = activitySid, Attributes = attributes };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Worker belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new Worker. It can be up to 64 characters long. </param>
        /// <param name="activitySid"> The SID of a valid Activity that will describe the new Worker's initial state. See [Activities](https://www.twilio.com/docs/taskrouter/api/activity) for more information. If not provided, the new Worker's initial state is the `default_activity_sid` configured on the Workspace. </param>
        /// <param name="attributes"> A valid JSON string that describes the new Worker. For example: `{ \\\"email\\\": \\\"Bob@example.com\\\", \\\"phone\\\": \\\"+5095551234\\\" }`. This data is passed to the `assignment_callback_url` when TaskRouter assigns a Task to the Worker. Defaults to {}. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<WorkerResource> CreateAsync(
                                                                                  string pathWorkspaceSid,
                                                                                  string friendlyName,
                                                                                  string activitySid = null,
                                                                                  string attributes = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateWorkerOptions(pathWorkspaceSid, friendlyName){  ActivitySid = activitySid, Attributes = attributes };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        private static Request BuildDeleteRequest(DeleteWorkerOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workers/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static bool Delete(DeleteWorkerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWorkerOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to delete. </param>
        /// <param name="pathSid"> The SID of the Worker resource to delete. </param>
        /// <param name="ifMatch"> The If-Match HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static bool Delete(string pathWorkspaceSid, string pathSid, string ifMatch = null, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkerOptions(pathWorkspaceSid, pathSid)         { IfMatch = ifMatch }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to delete. </param>
        /// <param name="pathSid"> The SID of the Worker resource to delete. </param>
        /// <param name="ifMatch"> The If-Match HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathWorkspaceSid, string pathSid, string ifMatch = null, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkerOptions(pathWorkspaceSid, pathSid)  { IfMatch = ifMatch };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchWorkerOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workers/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static WorkerResource Fetch(FetchWorkerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<WorkerResource> FetchAsync(FetchWorkerOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to fetch. </param>
        /// <param name="pathSid"> The SID of the Worker resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static WorkerResource Fetch(
                                         string pathWorkspaceSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchWorkerOptions(pathWorkspaceSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to fetch. </param>
        /// <param name="pathSid"> The SID of the Worker resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<WorkerResource> FetchAsync(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkerOptions(pathWorkspaceSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadWorkerOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workers";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static ResourceSet<WorkerResource> Read(ReadWorkerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<WorkerResource>.FromJson("workers", response.Content);
            return new ResourceSet<WorkerResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WorkerResource>> ReadAsync(ReadWorkerOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<WorkerResource>.FromJson("workers", response.Content);
            return new ResourceSet<WorkerResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workers to read. </param>
        /// <param name="activityName"> The `activity_name` of the Worker resources to read. </param>
        /// <param name="activitySid"> The `activity_sid` of the Worker resources to read. </param>
        /// <param name="available"> Whether to return only Worker resources that are available or unavailable. Can be `true`, `1`, or `yes` to return Worker resources that are available, and `false`, or any value returns the Worker resources that are not available. </param>
        /// <param name="friendlyName"> The `friendly_name` of the Worker resources to read. </param>
        /// <param name="targetWorkersExpression"> Filter by Workers that would match an expression. In addition to fields in the workers' attributes, the expression can include the following worker fields: `sid`, `friendly_name`, `activity_sid`, or `activity_name` </param>
        /// <param name="taskQueueName"> The `friendly_name` of the TaskQueue that the Workers to read are eligible for. </param>
        /// <param name="taskQueueSid"> The SID of the TaskQueue that the Workers to read are eligible for. </param>
        /// <param name="ordering"> Sorting parameter for Workers </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static ResourceSet<WorkerResource> Read(
                                                     string pathWorkspaceSid,
                                                     string activityName = null,
                                                     string activitySid = null,
                                                     string available = null,
                                                     string friendlyName = null,
                                                     string targetWorkersExpression = null,
                                                     string taskQueueName = null,
                                                     string taskQueueSid = null,
                                                     string ordering = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadWorkerOptions(pathWorkspaceSid){ ActivityName = activityName, ActivitySid = activitySid, Available = available, FriendlyName = friendlyName, TargetWorkersExpression = targetWorkersExpression, TaskQueueName = taskQueueName, TaskQueueSid = taskQueueSid, Ordering = ordering, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workers to read. </param>
        /// <param name="activityName"> The `activity_name` of the Worker resources to read. </param>
        /// <param name="activitySid"> The `activity_sid` of the Worker resources to read. </param>
        /// <param name="available"> Whether to return only Worker resources that are available or unavailable. Can be `true`, `1`, or `yes` to return Worker resources that are available, and `false`, or any value returns the Worker resources that are not available. </param>
        /// <param name="friendlyName"> The `friendly_name` of the Worker resources to read. </param>
        /// <param name="targetWorkersExpression"> Filter by Workers that would match an expression. In addition to fields in the workers' attributes, the expression can include the following worker fields: `sid`, `friendly_name`, `activity_sid`, or `activity_name` </param>
        /// <param name="taskQueueName"> The `friendly_name` of the TaskQueue that the Workers to read are eligible for. </param>
        /// <param name="taskQueueSid"> The SID of the TaskQueue that the Workers to read are eligible for. </param>
        /// <param name="ordering"> Sorting parameter for Workers </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WorkerResource>> ReadAsync(
                                                                                             string pathWorkspaceSid,
                                                                                             string activityName = null,
                                                                                             string activitySid = null,
                                                                                             string available = null,
                                                                                             string friendlyName = null,
                                                                                             string targetWorkersExpression = null,
                                                                                             string taskQueueName = null,
                                                                                             string taskQueueSid = null,
                                                                                             string ordering = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadWorkerOptions(pathWorkspaceSid){ ActivityName = activityName, ActivitySid = activitySid, Available = available, FriendlyName = friendlyName, TargetWorkersExpression = targetWorkersExpression, TaskQueueName = taskQueueName, TaskQueueSid = taskQueueSid, Ordering = ordering, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<WorkerResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<WorkerResource>.FromJson("workers", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<WorkerResource> NextPage(Page<WorkerResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WorkerResource>.FromJson("workers", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<WorkerResource> PreviousPage(Page<WorkerResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WorkerResource>.FromJson("workers", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateWorkerOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workers/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static WorkerResource Update(UpdateWorkerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<WorkerResource> UpdateAsync(UpdateWorkerOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to update. </param>
        /// <param name="pathSid"> The SID of the Worker resource to update. </param>
        /// <param name="activitySid"> The SID of a valid Activity that will describe the Worker's initial state. See [Activities](https://www.twilio.com/docs/taskrouter/api/activity) for more information. </param>
        /// <param name="attributes"> The JSON string that describes the Worker. For example: `{ \\\"email\\\": \\\"Bob@example.com\\\", \\\"phone\\\": \\\"+5095551234\\\" }`. This data is passed to the `assignment_callback_url` when TaskRouter assigns a Task to the Worker. Defaults to {}. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Worker. It can be up to 64 characters long. </param>
        /// <param name="rejectPendingReservations"> Whether to reject the Worker's pending reservations. This option is only valid if the Worker's new [Activity](https://www.twilio.com/docs/taskrouter/api/activity) resource has its `availability` property set to `False`. </param>
        /// <param name="ifMatch"> The If-Match HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns>
        public static WorkerResource Update(
                                          string pathWorkspaceSid,
                                          string pathSid,
                                          string activitySid = null,
                                          string attributes = null,
                                          string friendlyName = null,
                                          bool? rejectPendingReservations = null,
                                          string ifMatch = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateWorkerOptions(pathWorkspaceSid, pathSid){ ActivitySid = activitySid, Attributes = attributes, FriendlyName = friendlyName, RejectPendingReservations = rejectPendingReservations, IfMatch = ifMatch };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to update. </param>
        /// <param name="pathSid"> The SID of the Worker resource to update. </param>
        /// <param name="activitySid"> The SID of a valid Activity that will describe the Worker's initial state. See [Activities](https://www.twilio.com/docs/taskrouter/api/activity) for more information. </param>
        /// <param name="attributes"> The JSON string that describes the Worker. For example: `{ \\\"email\\\": \\\"Bob@example.com\\\", \\\"phone\\\": \\\"+5095551234\\\" }`. This data is passed to the `assignment_callback_url` when TaskRouter assigns a Task to the Worker. Defaults to {}. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Worker. It can be up to 64 characters long. </param>
        /// <param name="rejectPendingReservations"> Whether to reject the Worker's pending reservations. This option is only valid if the Worker's new [Activity](https://www.twilio.com/docs/taskrouter/api/activity) resource has its `availability` property set to `False`. </param>
        /// <param name="ifMatch"> The If-Match HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns>
        public static async System.Threading.Tasks.Task<WorkerResource> UpdateAsync(
                                                                              string pathWorkspaceSid,
                                                                              string pathSid,
                                                                              string activitySid = null,
                                                                              string attributes = null,
                                                                              string friendlyName = null,
                                                                              bool? rejectPendingReservations = null,
                                                                              string ifMatch = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateWorkerOptions(pathWorkspaceSid, pathSid){ ActivitySid = activitySid, Attributes = attributes, FriendlyName = friendlyName, RejectPendingReservations = rejectPendingReservations, IfMatch = ifMatch };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkerResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkerResource object represented by the provided JSON </returns>
        public static WorkerResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WorkerResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Worker resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The `friendly_name` of the Worker's current Activity. </summary> 
        [JsonProperty("activity_name")]
        public string ActivityName { get; private set; }

        ///<summary> The SID of the Worker's current Activity. </summary> 
        [JsonProperty("activity_sid")]
        public string ActivitySid { get; private set; }

        ///<summary> The JSON string that describes the Worker. For example: `{ \"email\": \"Bob@example.com\", \"phone\": \"+5095551234\" }`. **Note** If this property has been assigned a value, it will only be displayed in FETCH actions that return a single resource. Otherwise, this property will be null, even if it has a value. This data is passed to the `assignment_callback_url` when TaskRouter assigns a Task to the Worker. </summary> 
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }

        ///<summary> Whether the Worker is available to perform tasks. </summary> 
        [JsonProperty("available")]
        public bool? Available { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT of the last change to the Worker's activity specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. Used to calculate Workflow statistics. </summary> 
        [JsonProperty("date_status_changed")]
        public DateTime? DateStatusChanged { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The string that you assigned to describe the resource. Friendly names are case insensitive, and unique within the TaskRouter Workspace. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The unique string that we created to identify the Worker resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the Workspace that contains the Worker. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        ///<summary> The absolute URL of the Worker resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private WorkerResource() {

        }
    }
}

