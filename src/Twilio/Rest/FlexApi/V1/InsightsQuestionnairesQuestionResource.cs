/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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



namespace Twilio.Rest.FlexApi.V1
{
    public class InsightsQuestionnairesQuestionResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateInsightsQuestionnairesQuestionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QualityManagement/Questions";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To create a question for a Category </summary>
        /// <param name="options"> Create InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        public static InsightsQuestionnairesQuestionResource Create(CreateInsightsQuestionnairesQuestionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> To create a question for a Category </summary>
        /// <param name="options"> Create InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesQuestion </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesQuestionResource> CreateAsync(CreateInsightsQuestionnairesQuestionOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> To create a question for a Category </summary>
        /// <param name="categorySid"> The SID of the category </param>
        /// <param name="question"> The question. </param>
        /// <param name="answerSetId"> The answer_set for the question. </param>
        /// <param name="allowNa"> The flag to enable for disable NA for answer. </param>
        /// <param name="description"> The description for the question. </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        public static InsightsQuestionnairesQuestionResource Create(
                                          string categorySid,
                                          string question,
                                          string answerSetId,
                                          bool? allowNa,
                                          string description = null,
                                          string token = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateInsightsQuestionnairesQuestionOptions(categorySid, question, answerSetId, allowNa){  Description = description, Token = token };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> To create a question for a Category </summary>
        /// <param name="categorySid"> The SID of the category </param>
        /// <param name="question"> The question. </param>
        /// <param name="answerSetId"> The answer_set for the question. </param>
        /// <param name="allowNa"> The flag to enable for disable NA for answer. </param>
        /// <param name="description"> The description for the question. </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesQuestion </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesQuestionResource> CreateAsync(
                                                                                  string categorySid,
                                                                                  string question,
                                                                                  string answerSetId,
                                                                                  bool? allowNa,
                                                                                  string description = null,
                                                                                  string token = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateInsightsQuestionnairesQuestionOptions(categorySid, question, answerSetId, allowNa){  Description = description, Token = token };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        private static Request BuildDeleteRequest(DeleteInsightsQuestionnairesQuestionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QualityManagement/Questions/{QuestionSid}";

            string PathQuestionSid = options.PathQuestionSid;
            path = path.Replace("{"+"QuestionSid"+"}", PathQuestionSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        public static bool Delete(DeleteInsightsQuestionnairesQuestionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesQuestion </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteInsightsQuestionnairesQuestionOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathQuestionSid"> The SID of the question </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        public static bool Delete(string pathQuestionSid, string token = null, ITwilioRestClient client = null)
        {
            var options = new DeleteInsightsQuestionnairesQuestionOptions(pathQuestionSid)      { Token = token }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathQuestionSid"> The SID of the question </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesQuestion </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathQuestionSid, string token = null, ITwilioRestClient client = null)
        {
            var options = new DeleteInsightsQuestionnairesQuestionOptions(pathQuestionSid)  { Token = token };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadInsightsQuestionnairesQuestionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QualityManagement/Questions";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }
        /// <summary> To get all the question for the given categories </summary>
        /// <param name="options"> Read InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        public static ResourceSet<InsightsQuestionnairesQuestionResource> Read(ReadInsightsQuestionnairesQuestionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<InsightsQuestionnairesQuestionResource>.FromJson("questions", response.Content);
            return new ResourceSet<InsightsQuestionnairesQuestionResource>(page, options, client);
        }

        #if !NET35
        /// <summary> To get all the question for the given categories </summary>
        /// <param name="options"> Read InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesQuestion </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InsightsQuestionnairesQuestionResource>> ReadAsync(ReadInsightsQuestionnairesQuestionOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<InsightsQuestionnairesQuestionResource>.FromJson("questions", response.Content);
            return new ResourceSet<InsightsQuestionnairesQuestionResource>(page, options, client);
        }
        #endif
        /// <summary> To get all the question for the given categories </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="categorySid"> The list of category SIDs </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        public static ResourceSet<InsightsQuestionnairesQuestionResource> Read(
                                                     string token = null,
                                                     List<string> categorySid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadInsightsQuestionnairesQuestionOptions(){ Token = token, CategorySid = categorySid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> To get all the question for the given categories </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="categorySid"> The list of category SIDs </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesQuestion </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InsightsQuestionnairesQuestionResource>> ReadAsync(
                                                                                             string token = null,
                                                                                             List<string> categorySid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadInsightsQuestionnairesQuestionOptions(){ Token = token, CategorySid = categorySid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<InsightsQuestionnairesQuestionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<InsightsQuestionnairesQuestionResource>.FromJson("questions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<InsightsQuestionnairesQuestionResource> NextPage(Page<InsightsQuestionnairesQuestionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InsightsQuestionnairesQuestionResource>.FromJson("questions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<InsightsQuestionnairesQuestionResource> PreviousPage(Page<InsightsQuestionnairesQuestionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InsightsQuestionnairesQuestionResource>.FromJson("questions", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateInsightsQuestionnairesQuestionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QualityManagement/Questions/{QuestionSid}";

            string PathQuestionSid = options.PathQuestionSid;
            path = path.Replace("{"+"QuestionSid"+"}", PathQuestionSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To update the question </summary>
        /// <param name="options"> Update InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        public static InsightsQuestionnairesQuestionResource Update(UpdateInsightsQuestionnairesQuestionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> To update the question </summary>
        /// <param name="options"> Update InsightsQuestionnairesQuestion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesQuestion </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesQuestionResource> UpdateAsync(UpdateInsightsQuestionnairesQuestionOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> To update the question </summary>
        /// <param name="pathQuestionSid"> The SID of the question </param>
        /// <param name="allowNa"> The flag to enable for disable NA for answer. </param>
        /// <param name="categorySid"> The SID of the category </param>
        /// <param name="question"> The question. </param>
        /// <param name="description"> The description for the question. </param>
        /// <param name="answerSetId"> The answer_set for the question. </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesQuestion </returns>
        public static InsightsQuestionnairesQuestionResource Update(
                                          string pathQuestionSid,
                                          bool? allowNa,
                                          string categorySid = null,
                                          string question = null,
                                          string description = null,
                                          string answerSetId = null,
                                          string token = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateInsightsQuestionnairesQuestionOptions(pathQuestionSid, allowNa){ CategorySid = categorySid, Question = question, Description = description, AnswerSetId = answerSetId, Token = token };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> To update the question </summary>
        /// <param name="pathQuestionSid"> The SID of the question </param>
        /// <param name="allowNa"> The flag to enable for disable NA for answer. </param>
        /// <param name="categorySid"> The SID of the category </param>
        /// <param name="question"> The question. </param>
        /// <param name="description"> The description for the question. </param>
        /// <param name="answerSetId"> The answer_set for the question. </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesQuestion </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesQuestionResource> UpdateAsync(
                                                                              string pathQuestionSid,
                                                                              bool? allowNa,
                                                                              string categorySid = null,
                                                                              string question = null,
                                                                              string description = null,
                                                                              string answerSetId = null,
                                                                              string token = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateInsightsQuestionnairesQuestionOptions(pathQuestionSid, allowNa){ CategorySid = categorySid, Question = question, Description = description, AnswerSetId = answerSetId, Token = token };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InsightsQuestionnairesQuestionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InsightsQuestionnairesQuestionResource object represented by the provided JSON </returns>
        public static InsightsQuestionnairesQuestionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InsightsQuestionnairesQuestionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Flex Insights resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the question </summary> 
        [JsonProperty("question_sid")]
        public string QuestionSid { get; private set; }

        ///<summary> The question. </summary> 
        [JsonProperty("question")]
        public string Question { get; private set; }

        ///<summary> The description for the question. </summary> 
        [JsonProperty("description")]
        public string Description { get; private set; }

        ///<summary> The Category for the question. </summary> 
        [JsonProperty("category")]
        public object Category { get; private set; }

        ///<summary> The answer_set for the question. </summary> 
        [JsonProperty("answer_set_id")]
        public string AnswerSetId { get; private set; }

        ///<summary> The flag  to enable for disable NA for answer. </summary> 
        [JsonProperty("allow_na")]
        public bool? AllowNa { get; private set; }

        ///<summary> Integer value that tells a particular question is used by how many questionnaires </summary> 
        [JsonProperty("usage")]
        public int? Usage { get; private set; }

        ///<summary> Set of answers for the question </summary> 
        [JsonProperty("answer_set")]
        public object AnswerSet { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InsightsQuestionnairesQuestionResource() {

        }
    }
}

