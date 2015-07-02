using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MandsStoreAPI
{
    /// <summary>
    /// Contains information about a store facility.
    /// </summary>
    public class StoreFacility
    {
        /// <summary>
        /// The store facility's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
