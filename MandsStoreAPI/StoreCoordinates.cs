using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandsStoreAPI
{
    /// <summary>
    /// Represents geographical coordinates of a store.
    /// </summary>
    public class StoreCoordinates
    {
        /// <summary>
        /// The latitude represented in a decimal value.
        /// </summary>
        [JsonProperty("latitude")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// The longitude represented in a decimal value.
        /// </summary>
        [JsonProperty("longitude")]
        public decimal Longitude { get; set; }
    }
}
