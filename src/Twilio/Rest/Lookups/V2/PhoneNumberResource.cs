/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Lookups
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
using Twilio.Types;


namespace Twilio.Rest.Lookups.V2
{
    public class PhoneNumberResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class ValidationErrorEnum : StringEnum
        {
            private ValidationErrorEnum(string value) : base(value) {}
            public ValidationErrorEnum() {}
            public static implicit operator ValidationErrorEnum(string value)
            {
                return new ValidationErrorEnum(value);
            }

            public static readonly ValidationErrorEnum TooShort = new ValidationErrorEnum("TOO_SHORT");
            public static readonly ValidationErrorEnum TooLong = new ValidationErrorEnum("TOO_LONG");
            public static readonly ValidationErrorEnum InvalidButPossible = new ValidationErrorEnum("INVALID_BUT_POSSIBLE");
            public static readonly ValidationErrorEnum InvalidCountryCode = new ValidationErrorEnum("INVALID_COUNTRY_CODE");
            public static readonly ValidationErrorEnum InvalidLength = new ValidationErrorEnum("INVALID_LENGTH");
            public static readonly ValidationErrorEnum NotANumber = new ValidationErrorEnum("NOT_A_NUMBER");
        }

        
        private static Request BuildFetchRequest(FetchPhoneNumberOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/PhoneNumbers/{PhoneNumber}";

            string PathPhoneNumber = options.PathPhoneNumber;
            path = path.Replace("{"+"PhoneNumber"+"}", PathPhoneNumber);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Lookups,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Fetch(FetchPhoneNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> FetchAsync(FetchPhoneNumberOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathPhoneNumber"> The phone number to lookup in E.164 or national format. Default country code is +1 (North America). </param>
        /// <param name="fields"> A comma-separated list of fields to return. Possible values are caller_name, sim_swap, call_forwarding, live_activity, line_type_intelligence, identity_match, reassigned_number. </param>
        /// <param name="countryCode"> The [country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) used if the phone number provided is in national format. </param>
        /// <param name="firstName"> User’s first name. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="lastName"> User’s last name. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="addressLine1"> User’s first address line. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="addressLine2"> User’s second address line. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="city"> User’s city. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="state"> User’s country subdivision, such as state, province, or locality. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="postalCode"> User’s postal zip code. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="addressCountryCode"> User’s country, up to two characters. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="nationalId"> User’s national ID, such as SSN or Passport ID. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="dateOfBirth"> User’s date of birth, in YYYYMMDD format. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="lastVerifiedDate"> The date you obtained consent to call or text the end-user of the phone number or a date on which you are reasonably certain that the end-user could still be reached at that number. This query parameter is only used (optionally) for reassigned_number package requests. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Fetch(
                                         string pathPhoneNumber, 
                                         string fields = null, 
                                         string countryCode = null, 
                                         string firstName = null, 
                                         string lastName = null, 
                                         string addressLine1 = null, 
                                         string addressLine2 = null, 
                                         string city = null, 
                                         string state = null, 
                                         string postalCode = null, 
                                         string addressCountryCode = null, 
                                         string nationalId = null, 
                                         string dateOfBirth = null, 
                                         string lastVerifiedDate = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchPhoneNumberOptions(pathPhoneNumber){ Fields = fields,CountryCode = countryCode,FirstName = firstName,LastName = lastName,AddressLine1 = addressLine1,AddressLine2 = addressLine2,City = city,State = state,PostalCode = postalCode,AddressCountryCode = addressCountryCode,NationalId = nationalId,DateOfBirth = dateOfBirth,LastVerifiedDate = lastVerifiedDate };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathPhoneNumber"> The phone number to lookup in E.164 or national format. Default country code is +1 (North America). </param>
        /// <param name="fields"> A comma-separated list of fields to return. Possible values are caller_name, sim_swap, call_forwarding, live_activity, line_type_intelligence, identity_match, reassigned_number. </param>
        /// <param name="countryCode"> The [country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) used if the phone number provided is in national format. </param>
        /// <param name="firstName"> User’s first name. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="lastName"> User’s last name. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="addressLine1"> User’s first address line. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="addressLine2"> User’s second address line. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="city"> User’s city. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="state"> User’s country subdivision, such as state, province, or locality. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="postalCode"> User’s postal zip code. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="addressCountryCode"> User’s country, up to two characters. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="nationalId"> User’s national ID, such as SSN or Passport ID. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="dateOfBirth"> User’s date of birth, in YYYYMMDD format. This query parameter is only used (optionally) for identity_match package requests. </param>
        /// <param name="lastVerifiedDate"> The date you obtained consent to call or text the end-user of the phone number or a date on which you are reasonably certain that the end-user could still be reached at that number. This query parameter is only used (optionally) for reassigned_number package requests. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> FetchAsync(string pathPhoneNumber, string fields = null, string countryCode = null, string firstName = null, string lastName = null, string addressLine1 = null, string addressLine2 = null, string city = null, string state = null, string postalCode = null, string addressCountryCode = null, string nationalId = null, string dateOfBirth = null, string lastVerifiedDate = null, ITwilioRestClient client = null)
        {
            var options = new FetchPhoneNumberOptions(pathPhoneNumber){ Fields = fields,CountryCode = countryCode,FirstName = firstName,LastName = lastName,AddressLine1 = addressLine1,AddressLine2 = addressLine2,City = city,State = state,PostalCode = postalCode,AddressCountryCode = addressCountryCode,NationalId = nationalId,DateOfBirth = dateOfBirth,LastVerifiedDate = lastVerifiedDate };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PhoneNumberResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PhoneNumberResource object represented by the provided JSON </returns>
        public static PhoneNumberResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PhoneNumberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> International dialing prefix of the phone number defined in the E.164 standard. </summary> 
        [JsonProperty("calling_country_code")]
        public string CallingCountryCode { get; private set; }

        ///<summary> The phone number's [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). </summary> 
        [JsonProperty("country_code")]
        public string CountryCode { get; private set; }

        ///<summary> The phone number in [E.164](https://www.twilio.com/docs/glossary/what-e164) format, which consists of a + followed by the country code and subscriber number. </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> The phone number in [national format](https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers). </summary> 
        [JsonProperty("national_format")]
        public string NationalFormat { get; private set; }

        ///<summary> Boolean which indicates if the phone number is in a valid range that can be freely assigned by a carrier to a user. </summary> 
        [JsonProperty("valid")]
        public bool? Valid { get; private set; }

        ///<summary> Contains reasons why a phone number is invalid. Possible values: TOO_SHORT, TOO_LONG, INVALID_BUT_POSSIBLE, INVALID_COUNTRY_CODE, INVALID_LENGTH, NOT_A_NUMBER. </summary> 
        [JsonProperty("validation_errors")]
        public List<PhoneNumberResource.ValidationErrorEnum> ValidationErrors { get; private set; }

        ///<summary> An object that contains caller name information based on [CNAM](https://support.twilio.com/hc/en-us/articles/360051670533-Getting-Started-with-CNAM-Caller-ID). </summary> 
        [JsonProperty("caller_name")]
        public object CallerName { get; private set; }

        ///<summary> An object that contains information on the last date the subscriber identity module (SIM) was changed for a mobile phone number. </summary> 
        [JsonProperty("sim_swap")]
        public object SimSwap { get; private set; }

        ///<summary> An object that contains information on the unconditional call forwarding status of mobile phone number. </summary> 
        [JsonProperty("call_forwarding")]
        public object CallForwarding { get; private set; }

        ///<summary> An object that contains live activity information for a mobile phone number. </summary> 
        [JsonProperty("live_activity")]
        public object LiveActivity { get; private set; }

        ///<summary> An object that contains line type information including the carrier name, mobile country code, and mobile network code. </summary> 
        [JsonProperty("line_type_intelligence")]
        public object LineTypeIntelligence { get; private set; }

        ///<summary> An object that contains identity match information. The result of comparing user-provided information including name, address, date of birth, national ID, against authoritative phone-based data sources </summary> 
        [JsonProperty("identity_match")]
        public object IdentityMatch { get; private set; }

        ///<summary> An object that contains reassigned number information. Reassigned Numbers will return a phone number's reassignment status given a phone number and date </summary> 
        [JsonProperty("reassigned_number")]
        public object ReassignedNumber { get; private set; }

        ///<summary> An object that contains information on if a phone number has been currently or previously blocked by Verify Fraud Guard for receiving malicious SMS pumping traffic as well as other signals associated with risky carriers and low conversion rates. </summary> 
        [JsonProperty("sms_pumping_risk")]
        public object SmsPumpingRisk { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private PhoneNumberResource() {

        }
    }
}

