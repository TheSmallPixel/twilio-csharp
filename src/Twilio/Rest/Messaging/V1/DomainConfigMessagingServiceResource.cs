/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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



namespace Twilio.Rest.Messaging.V1
{
    public class DomainConfigMessagingServiceResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchDomainConfigMessagingServiceOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/LinkShortening/MessagingService/{MessagingServiceSid}/DomainConfig";

            string PathMessagingServiceSid = options.PathMessagingServiceSid;
            path = path.Replace("{"+"MessagingServiceSid"+"}", PathMessagingServiceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch DomainConfigMessagingService parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainConfigMessagingService </returns>
        public static DomainConfigMessagingServiceResource Fetch(FetchDomainConfigMessagingServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch DomainConfigMessagingService parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainConfigMessagingService </returns>
        public static async System.Threading.Tasks.Task<DomainConfigMessagingServiceResource> FetchAsync(FetchDomainConfigMessagingServiceOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathMessagingServiceSid"> Unique string used to identify the Messaging service that this domain should be associated with. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainConfigMessagingService </returns>
        public static DomainConfigMessagingServiceResource Fetch(
                                         string pathMessagingServiceSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchDomainConfigMessagingServiceOptions(pathMessagingServiceSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathMessagingServiceSid"> Unique string used to identify the Messaging service that this domain should be associated with. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainConfigMessagingService </returns>
        public static async System.Threading.Tasks.Task<DomainConfigMessagingServiceResource> FetchAsync(string pathMessagingServiceSid, ITwilioRestClient client = null)
        {
            var options = new FetchDomainConfigMessagingServiceOptions(pathMessagingServiceSid){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a DomainConfigMessagingServiceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DomainConfigMessagingServiceResource object represented by the provided JSON </returns>
        public static DomainConfigMessagingServiceResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<DomainConfigMessagingServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Domain resource. </summary> 
        [JsonProperty("domain_sid")]
        public string DomainSid { get; private set; }

        ///<summary> The unique string that we created to identify the Domain config (prefix ZK). </summary> 
        [JsonProperty("config_sid")]
        public string ConfigSid { get; private set; }

        ///<summary> The unique string that identifies the messaging service </summary> 
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }

        ///<summary> Any requests we receive to this domain that do not match an existing shortened message will be redirected to the fallback url. These will likely be either expired messages, random misdirected traffic, or intentional scraping. </summary> 
        [JsonProperty("fallback_url")]
        public Uri FallbackUrl { get; private set; }

        ///<summary> URL to receive click events to your webhook whenever the recipients click on the shortened links. </summary> 
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; private set; }

        ///<summary> Boolean field to set customer delivery preference when there is a failure in linkShortening service </summary> 
        [JsonProperty("continue_on_failure")]
        public bool? ContinueOnFailure { get; private set; }

        ///<summary> Date this Domain Config was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> Date that this Domain Config was last updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private DomainConfigMessagingServiceResource() {

        }
    }
}

