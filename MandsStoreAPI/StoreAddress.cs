using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandsStoreAPI
{
    /// <summary>
    /// Represents the address of a store.
    /// </summary>
    public class StoreAddress
    {
        /// <summary>
        /// First line of address.
        /// </summary>
        [JsonProperty("addressLine1")]
        public string Line1 { get; set; }

        /// <summary>
        /// Second line of address.
        /// </summary>
        [JsonProperty("addressLine2")]
        public string Line2 { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// County name.
        /// </summary>
        [JsonProperty("county")]
        public string County { get; set; }

        /// <summary>
        /// 2-letter ISO country code.
        /// </summary>
        [JsonProperty("isoTwoCountryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Country name.
        /// </summary>
        [JsonProperty("country")]
        public string CountryName { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }
}
