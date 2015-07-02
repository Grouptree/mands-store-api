using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MandsStoreAPI
{
    /// <summary>
    /// Contains information about a store service.
    /// </summary>
    public class StoreService
    {
        /// <summary>
        /// The store service's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
