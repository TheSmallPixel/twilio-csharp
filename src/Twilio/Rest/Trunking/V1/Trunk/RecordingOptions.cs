/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trunking
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




namespace Twilio.Rest.Trunking.V1.Trunk
{
    /// <summary> fetch </summary>
    public class FetchRecordingOptions : IOptions<RecordingResource>
    {
    
        ///<summary> The SID of the Trunk from which to fetch the recording settings. </summary> 
        public string PathTrunkSid { get; }



        /// <summary> Construct a new FetchRecordingOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to fetch the recording settings. </param>
        public FetchRecordingOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> update </summary>
    public class UpdateRecordingOptions : IOptions<RecordingResource>
    {
    
        ///<summary> The SID of the Trunk that will have its recording settings updated. </summary> 
        public string PathTrunkSid { get; }

        
        public RecordingResource.RecordingModeEnum Mode { get; set; }

        
        public RecordingResource.RecordingTrimEnum Trim { get; set; }



        /// <summary> Construct a new UpdateRecordingOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk that will have its recording settings updated. </param>
        public UpdateRecordingOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Mode != null)
            {
                p.Add(new KeyValuePair<string, string>("Mode", Mode.ToString()));
            }
            if (Trim != null)
            {
                p.Add(new KeyValuePair<string, string>("Trim", Trim.ToString()));
            }
            return p;
        }
        

    }


}

