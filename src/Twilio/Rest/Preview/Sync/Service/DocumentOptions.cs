/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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




namespace Twilio.Rest.Preview.Sync.Service
{

    /// <summary> create </summary>
    public class CreateDocumentOptions : IOptions<DocumentResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string UniqueName { get; set; }

        
        public object Data { get; set; }


        /// <summary> Construct a new CreateSyncDocumentOptions </summary>
        /// <param name="pathServiceSid">  </param>
        public CreateDocumentOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteDocumentOptions : IOptions<DocumentResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new DeleteSyncDocumentOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        public DeleteDocumentOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchDocumentOptions : IOptions<DocumentResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new FetchSyncDocumentOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        public FetchDocumentOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadDocumentOptions : ReadOptions<DocumentResource>
    {
    
        
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListSyncDocumentOptions </summary>
        /// <param name="pathServiceSid">  </param>
        public ReadDocumentOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateDocumentOptions : IOptions<DocumentResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathSid { get; }

        
        public object Data { get; }

        ///<summary> The If-Match HTTP request header </summary> 
        public string IfMatch { get; set; }



        /// <summary> Construct a new UpdateSyncDocumentOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="data">  </param>
        public UpdateDocumentOptions(string pathServiceSid, string pathSid, object data)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
            Data = data;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (IfMatch != null)
        {
            p.Add(new KeyValuePair<string, string>("If-Match", IfMatch));
        }
        return p;
    }

    }


}

