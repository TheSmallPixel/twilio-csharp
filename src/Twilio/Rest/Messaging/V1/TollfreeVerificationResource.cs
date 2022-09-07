/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// TollfreeVerificationResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Messaging.V1
{

    public class TollfreeVerificationResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum PendingReview = new StatusEnum("PENDING_REVIEW");
            public static readonly StatusEnum InReview = new StatusEnum("IN_REVIEW");
            public static readonly StatusEnum TwilioApproved = new StatusEnum("TWILIO_APPROVED");
            public static readonly StatusEnum TwilioRejected = new StatusEnum("TWILIO_REJECTED");
        }

        public sealed class OptInTypeEnum : StringEnum
        {
            private OptInTypeEnum(string value) : base(value) {}
            public OptInTypeEnum() {}
            public static implicit operator OptInTypeEnum(string value)
            {
                return new OptInTypeEnum(value);
            }

            public static readonly OptInTypeEnum Verbal = new OptInTypeEnum("VERBAL");
            public static readonly OptInTypeEnum WebForm = new OptInTypeEnum("WEB_FORM");
            public static readonly OptInTypeEnum PaperForm = new OptInTypeEnum("PAPER_FORM");
            public static readonly OptInTypeEnum ViaText = new OptInTypeEnum("VIA_TEXT");
            public static readonly OptInTypeEnum MobileQrCode = new OptInTypeEnum("MOBILE_QR_CODE");
        }

        private static Request BuildFetchRequest(FetchTollfreeVerificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Tollfree/Verifications/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TollfreeVerification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TollfreeVerification </returns>
        public static TollfreeVerificationResource Fetch(FetchTollfreeVerificationOptions options,
                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TollfreeVerification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TollfreeVerification </returns>
        public static async System.Threading.Tasks.Task<TollfreeVerificationResource> FetchAsync(FetchTollfreeVerificationOptions options,
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> Tollfree Verification Sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TollfreeVerification </returns>
        public static TollfreeVerificationResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchTollfreeVerificationOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> Tollfree Verification Sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TollfreeVerification </returns>
        public static async System.Threading.Tasks.Task<TollfreeVerificationResource> FetchAsync(string pathSid,
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new FetchTollfreeVerificationOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadTollfreeVerificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Tollfree/Verifications",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read TollfreeVerification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TollfreeVerification </returns>
        public static ResourceSet<TollfreeVerificationResource> Read(ReadTollfreeVerificationOptions options,
                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<TollfreeVerificationResource>.FromJson("verifications", response.Content);
            return new ResourceSet<TollfreeVerificationResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read TollfreeVerification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TollfreeVerification </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TollfreeVerificationResource>> ReadAsync(ReadTollfreeVerificationOptions options,
                                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TollfreeVerificationResource>.FromJson("verifications", response.Content);
            return new ResourceSet<TollfreeVerificationResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="tollfreePhoneNumberSid"> The SID of the Phone Number associated with the Tollfree Verification </param>
        /// <param name="status"> The compliance status of the Tollfree Verification record. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TollfreeVerification </returns>
        public static ResourceSet<TollfreeVerificationResource> Read(string tollfreePhoneNumberSid = null,
                                                                     TollfreeVerificationResource.StatusEnum status = null,
                                                                     int? pageSize = null,
                                                                     long? limit = null,
                                                                     ITwilioRestClient client = null)
        {
            var options = new ReadTollfreeVerificationOptions(){TollfreePhoneNumberSid = tollfreePhoneNumberSid, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="tollfreePhoneNumberSid"> The SID of the Phone Number associated with the Tollfree Verification </param>
        /// <param name="status"> The compliance status of the Tollfree Verification record. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TollfreeVerification </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TollfreeVerificationResource>> ReadAsync(string tollfreePhoneNumberSid = null,
                                                                                                             TollfreeVerificationResource.StatusEnum status = null,
                                                                                                             int? pageSize = null,
                                                                                                             long? limit = null,
                                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadTollfreeVerificationOptions(){TollfreePhoneNumberSid = tollfreePhoneNumberSid, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<TollfreeVerificationResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TollfreeVerificationResource>.FromJson("verifications", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<TollfreeVerificationResource> NextPage(Page<TollfreeVerificationResource> page,
                                                                  ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Messaging)
            );

            var response = client.Request(request);
            return Page<TollfreeVerificationResource>.FromJson("verifications", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<TollfreeVerificationResource> PreviousPage(Page<TollfreeVerificationResource> page,
                                                                      ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Messaging)
            );

            var response = client.Request(request);
            return Page<TollfreeVerificationResource>.FromJson("verifications", response.Content);
        }

        private static Request BuildCreateRequest(CreateTollfreeVerificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                "/v1/Tollfree/Verifications",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create TollfreeVerification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TollfreeVerification </returns>
        public static TollfreeVerificationResource Create(CreateTollfreeVerificationOptions options,
                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create TollfreeVerification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TollfreeVerification </returns>
        public static async System.Threading.Tasks.Task<TollfreeVerificationResource> CreateAsync(CreateTollfreeVerificationOptions options,
                                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="businessName"> The name of the business or organization using the Tollfree number </param>
        /// <param name="businessWebsite"> The website of the business or organization using the Tollfree number </param>
        /// <param name="notificationEmail"> The email address to receive the notification about the verification result.
        ///                         </param>
        /// <param name="useCaseCategories"> The category of the use case for the Tollfree Number. List as many are applicable.
        ///                         </param>
        /// <param name="useCaseSummary"> Further explaination on how messaging is used by the business or organization </param>
        /// <param name="productionMessageSample"> An example of message content, i.e. a sample message </param>
        /// <param name="optInImageUrls"> Link to an image that shows the opt-in workflow. Multiple images allowed and must be
        ///                      a publicly hosted URL </param>
        /// <param name="optInType"> Describe how a user opts-in to text messages </param>
        /// <param name="messageVolume"> Estimate monthly volume of messages from the Tollfree Number </param>
        /// <param name="tollfreePhoneNumberSid"> The SID of the Phone Number associated with the Tollfree Verification </param>
        /// <param name="customerProfileSid"> Customer's Profile Bundle BundleSid </param>
        /// <param name="businessStreetAddress"> The address of the business or organization using the Tollfree number </param>
        /// <param name="businessStreetAddress2"> The address of the business or organization using the Tollfree number </param>
        /// <param name="businessCity"> The city of the business or organization using the Tollfree number </param>
        /// <param name="businessStateProvinceRegion"> The state/province/region of the business or organization using the
        ///                                   Tollfree number </param>
        /// <param name="businessPostalCode"> The postal code of the business or organization using the Tollfree number </param>
        /// <param name="businessCountry"> The country of the business or organization using the Tollfree number </param>
        /// <param name="additionalInformation"> Additional information to be provided for verification </param>
        /// <param name="businessContactFirstName"> The first name of the contact for the business or organization using the
        ///                                Tollfree number </param>
        /// <param name="businessContactLastName"> The last name of the contact for the business or organization using the
        ///                               Tollfree number </param>
        /// <param name="businessContactEmail"> The email address of the contact for the business or organization using the
        ///                            Tollfree number </param>
        /// <param name="businessContactPhone"> The phone number of the contact for the business or organization using the
        ///                            Tollfree number </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TollfreeVerification </returns>
        public static TollfreeVerificationResource Create(string businessName,
                                                          string businessWebsite,
                                                          string notificationEmail,
                                                          List<string> useCaseCategories,
                                                          string useCaseSummary,
                                                          string productionMessageSample,
                                                          List<string> optInImageUrls,
                                                          TollfreeVerificationResource.OptInTypeEnum optInType,
                                                          string messageVolume,
                                                          string tollfreePhoneNumberSid,
                                                          string customerProfileSid = null,
                                                          string businessStreetAddress = null,
                                                          string businessStreetAddress2 = null,
                                                          string businessCity = null,
                                                          string businessStateProvinceRegion = null,
                                                          string businessPostalCode = null,
                                                          string businessCountry = null,
                                                          string additionalInformation = null,
                                                          string businessContactFirstName = null,
                                                          string businessContactLastName = null,
                                                          string businessContactEmail = null,
                                                          Types.PhoneNumber businessContactPhone = null,
                                                          ITwilioRestClient client = null)
        {
            var options = new CreateTollfreeVerificationOptions(businessName, businessWebsite, notificationEmail, useCaseCategories, useCaseSummary, productionMessageSample, optInImageUrls, optInType, messageVolume, tollfreePhoneNumberSid){CustomerProfileSid = customerProfileSid, BusinessStreetAddress = businessStreetAddress, BusinessStreetAddress2 = businessStreetAddress2, BusinessCity = businessCity, BusinessStateProvinceRegion = businessStateProvinceRegion, BusinessPostalCode = businessPostalCode, BusinessCountry = businessCountry, AdditionalInformation = additionalInformation, BusinessContactFirstName = businessContactFirstName, BusinessContactLastName = businessContactLastName, BusinessContactEmail = businessContactEmail, BusinessContactPhone = businessContactPhone};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="businessName"> The name of the business or organization using the Tollfree number </param>
        /// <param name="businessWebsite"> The website of the business or organization using the Tollfree number </param>
        /// <param name="notificationEmail"> The email address to receive the notification about the verification result.
        ///                         </param>
        /// <param name="useCaseCategories"> The category of the use case for the Tollfree Number. List as many are applicable.
        ///                         </param>
        /// <param name="useCaseSummary"> Further explaination on how messaging is used by the business or organization </param>
        /// <param name="productionMessageSample"> An example of message content, i.e. a sample message </param>
        /// <param name="optInImageUrls"> Link to an image that shows the opt-in workflow. Multiple images allowed and must be
        ///                      a publicly hosted URL </param>
        /// <param name="optInType"> Describe how a user opts-in to text messages </param>
        /// <param name="messageVolume"> Estimate monthly volume of messages from the Tollfree Number </param>
        /// <param name="tollfreePhoneNumberSid"> The SID of the Phone Number associated with the Tollfree Verification </param>
        /// <param name="customerProfileSid"> Customer's Profile Bundle BundleSid </param>
        /// <param name="businessStreetAddress"> The address of the business or organization using the Tollfree number </param>
        /// <param name="businessStreetAddress2"> The address of the business or organization using the Tollfree number </param>
        /// <param name="businessCity"> The city of the business or organization using the Tollfree number </param>
        /// <param name="businessStateProvinceRegion"> The state/province/region of the business or organization using the
        ///                                   Tollfree number </param>
        /// <param name="businessPostalCode"> The postal code of the business or organization using the Tollfree number </param>
        /// <param name="businessCountry"> The country of the business or organization using the Tollfree number </param>
        /// <param name="additionalInformation"> Additional information to be provided for verification </param>
        /// <param name="businessContactFirstName"> The first name of the contact for the business or organization using the
        ///                                Tollfree number </param>
        /// <param name="businessContactLastName"> The last name of the contact for the business or organization using the
        ///                               Tollfree number </param>
        /// <param name="businessContactEmail"> The email address of the contact for the business or organization using the
        ///                            Tollfree number </param>
        /// <param name="businessContactPhone"> The phone number of the contact for the business or organization using the
        ///                            Tollfree number </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TollfreeVerification </returns>
        public static async System.Threading.Tasks.Task<TollfreeVerificationResource> CreateAsync(string businessName,
                                                                                                  string businessWebsite,
                                                                                                  string notificationEmail,
                                                                                                  List<string> useCaseCategories,
                                                                                                  string useCaseSummary,
                                                                                                  string productionMessageSample,
                                                                                                  List<string> optInImageUrls,
                                                                                                  TollfreeVerificationResource.OptInTypeEnum optInType,
                                                                                                  string messageVolume,
                                                                                                  string tollfreePhoneNumberSid,
                                                                                                  string customerProfileSid = null,
                                                                                                  string businessStreetAddress = null,
                                                                                                  string businessStreetAddress2 = null,
                                                                                                  string businessCity = null,
                                                                                                  string businessStateProvinceRegion = null,
                                                                                                  string businessPostalCode = null,
                                                                                                  string businessCountry = null,
                                                                                                  string additionalInformation = null,
                                                                                                  string businessContactFirstName = null,
                                                                                                  string businessContactLastName = null,
                                                                                                  string businessContactEmail = null,
                                                                                                  Types.PhoneNumber businessContactPhone = null,
                                                                                                  ITwilioRestClient client = null)
        {
            var options = new CreateTollfreeVerificationOptions(businessName, businessWebsite, notificationEmail, useCaseCategories, useCaseSummary, productionMessageSample, optInImageUrls, optInType, messageVolume, tollfreePhoneNumberSid){CustomerProfileSid = customerProfileSid, BusinessStreetAddress = businessStreetAddress, BusinessStreetAddress2 = businessStreetAddress2, BusinessCity = businessCity, BusinessStateProvinceRegion = businessStateProvinceRegion, BusinessPostalCode = businessPostalCode, BusinessCountry = businessCountry, AdditionalInformation = additionalInformation, BusinessContactFirstName = businessContactFirstName, BusinessContactLastName = businessContactLastName, BusinessContactEmail = businessContactEmail, BusinessContactPhone = businessContactPhone};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a TollfreeVerificationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TollfreeVerificationResource object represented by the provided JSON </returns>
        public static TollfreeVerificationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TollfreeVerificationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Tollfree Verification Sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Customer's Profile Bundle BundleSid
        /// </summary>
        [JsonProperty("customer_profile_sid")]
        public string CustomerProfileSid { get; private set; }
        /// <summary>
        /// Tollfree TrustProduct Bundle BundleSid
        /// </summary>
        [JsonProperty("trust_product_sid")]
        public string TrustProductSid { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The SID of the Regulated Item
        /// </summary>
        [JsonProperty("regulated_item_sid")]
        public string RegulatedItemSid { get; private set; }
        /// <summary>
        /// The name of the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_name")]
        public string BusinessName { get; private set; }
        /// <summary>
        /// The address of the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_street_address")]
        public string BusinessStreetAddress { get; private set; }
        /// <summary>
        /// The address of the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_street_address2")]
        public string BusinessStreetAddress2 { get; private set; }
        /// <summary>
        /// The city of the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_city")]
        public string BusinessCity { get; private set; }
        /// <summary>
        /// The state/province/region of the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_state_province_region")]
        public string BusinessStateProvinceRegion { get; private set; }
        /// <summary>
        /// The postal code of the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_postal_code")]
        public string BusinessPostalCode { get; private set; }
        /// <summary>
        /// The country of the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_country")]
        public string BusinessCountry { get; private set; }
        /// <summary>
        /// The website of the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_website")]
        public string BusinessWebsite { get; private set; }
        /// <summary>
        /// The first name of the contact for the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_contact_first_name")]
        public string BusinessContactFirstName { get; private set; }
        /// <summary>
        /// The last name of the contact for the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_contact_last_name")]
        public string BusinessContactLastName { get; private set; }
        /// <summary>
        /// The email address of the contact for the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_contact_email")]
        public string BusinessContactEmail { get; private set; }
        /// <summary>
        /// The phone number of the contact for the business or organization using the Tollfree number
        /// </summary>
        [JsonProperty("business_contact_phone")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber BusinessContactPhone { get; private set; }
        /// <summary>
        /// The email address to receive the notification about the verification result.
        /// </summary>
        [JsonProperty("notification_email")]
        public string NotificationEmail { get; private set; }
        /// <summary>
        /// The category of the use case for the Tollfree Number. List as many are applicable.
        /// </summary>
        [JsonProperty("use_case_categories")]
        public List<string> UseCaseCategories { get; private set; }
        /// <summary>
        /// Further explaination on how messaging is used by the business or organization
        /// </summary>
        [JsonProperty("use_case_summary")]
        public string UseCaseSummary { get; private set; }
        /// <summary>
        /// An example of message content, i.e. a sample message
        /// </summary>
        [JsonProperty("production_message_sample")]
        public string ProductionMessageSample { get; private set; }
        /// <summary>
        /// Link to an image that shows the opt-in workflow. Multiple images allowed and must be a publicly hosted URL
        /// </summary>
        [JsonProperty("opt_in_image_urls")]
        public List<string> OptInImageUrls { get; private set; }
        /// <summary>
        /// Describe how a user opts-in to text messages
        /// </summary>
        [JsonProperty("opt_in_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TollfreeVerificationResource.OptInTypeEnum OptInType { get; private set; }
        /// <summary>
        /// Estimate monthly volume of messages from the Tollfree Number
        /// </summary>
        [JsonProperty("message_volume")]
        public string MessageVolume { get; private set; }
        /// <summary>
        /// Additional information to be provided for verification
        /// </summary>
        [JsonProperty("additional_information")]
        public string AdditionalInformation { get; private set; }
        /// <summary>
        /// The SID of the Phone Number associated with the Tollfree Verification
        /// </summary>
        [JsonProperty("tollfree_phone_number_sid")]
        public string TollfreePhoneNumberSid { get; private set; }
        /// <summary>
        /// The compliance status of the Tollfree Verification record.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TollfreeVerificationResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The absolute URL of the Tollfree Verification
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The URLs of the documents associated with the Tollfree Verification resource
        /// </summary>
        [JsonProperty("resource_links")]
        public object ResourceLinks { get; private set; }

        private TollfreeVerificationResource()
        {

        }
    }

}