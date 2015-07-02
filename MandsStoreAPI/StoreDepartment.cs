using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MandsStoreAPI
{
    /// <summary>
    /// Contains information about a store department.
    /// </summary>
    public class StoreDepartment
    {
        /// <summary>
        /// The store department's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
