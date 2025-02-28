/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Insights
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Insights.V1
{
    /// <summary> Get a specific Conference Summary. </summary>
    public class FetchConferenceOptions : IOptions<ConferenceResource>
    {
    
        ///<summary> The unique SID identifier of the Conference. </summary> 
        public string PathConferenceSid { get; }



        /// <summary> Construct a new FetchConferenceOptions </summary>
        /// <param name="pathConferenceSid"> The unique SID identifier of the Conference. </param>
        public FetchConferenceOptions(string pathConferenceSid)
        {
            PathConferenceSid = pathConferenceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Get a list of Conference Summaries. </summary>
    public class ReadConferenceOptions : ReadOptions<ConferenceResource>
    {
    
        ///<summary> The SID of the conference. </summary> 
        public string ConferenceSid { get; set; }

        ///<summary> Custom label for the conference resource, up to 64 characters. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Conference status. </summary> 
        public string Status { get; set; }

        ///<summary> Conferences created after the provided timestamp specified in ISO 8601 format </summary> 
        public string CreatedAfter { get; set; }

        ///<summary> Conferences created before the provided timestamp specified in ISO 8601 format. </summary> 
        public string CreatedBefore { get; set; }

        ///<summary> Twilio region where the conference media was mixed. </summary> 
        public string MixerRegion { get; set; }

        ///<summary> Tags applied by Twilio for common potential configuration, quality, or performance issues. </summary> 
        public string Tags { get; set; }

        ///<summary> Account SID for the subaccount whose resources you wish to retrieve. </summary> 
        public string Subaccount { get; set; }

        ///<summary> Potential configuration, behavior, or performance issues detected during the conference. </summary> 
        public string DetectedIssues { get; set; }

        ///<summary> Conference end reason; e.g. last participant left, modified by API, etc. </summary> 
        public string EndReason { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ConferenceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceSid", ConferenceSid));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }
            if (CreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedAfter", CreatedAfter));
            }
            if (CreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBefore", CreatedBefore));
            }
            if (MixerRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("MixerRegion", MixerRegion));
            }
            if (Tags != null)
            {
                p.Add(new KeyValuePair<string, string>("Tags", Tags));
            }
            if (Subaccount != null)
            {
                p.Add(new KeyValuePair<string, string>("Subaccount", Subaccount));
            }
            if (DetectedIssues != null)
            {
                p.Add(new KeyValuePair<string, string>("DetectedIssues", DetectedIssues));
            }
            if (EndReason != null)
            {
                p.Add(new KeyValuePair<string, string>("EndReason", EndReason));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

