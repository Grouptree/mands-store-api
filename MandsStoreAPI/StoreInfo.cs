using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandsStoreAPI
{
    /// <summary>
    /// Represents information about an M&S Store.
    /// </summary>
    public class StoreInfo
    {
        /// <summary>
        /// An integer that uniquely identifies the store in the API.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the store.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the store.
        /// </summary>
        [JsonProperty("storeType")]
        public string StoreType { get; set; }

        /// <summary>
        /// The geographical coordinates of the store.
        /// </summary>
        [JsonProperty("coordinates")]
        public StoreCoordinates Coordinates { get; set; }

        /// <summary>
        /// The normal opening hours for this store.
        /// </summary>
        [JsonProperty("coreOpeningHours")]
        public List<StoreOpeningHours> CoreOpeningHours { get; set; }

        /// <summary>
        /// Special opening hours for this store.
        /// </summary>
        [JsonProperty("specialOpeningHours")]
        public List<StoreOpeningHours> SpecialOpeningHours { get; set; }

        /// <summary>
        /// The store's address.
        /// </summary>
        [JsonProperty("address")]
        public StoreAddress Address { get; set; }

        /// <summary>
        /// The store's telephone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The store's fax number.
        /// </summary>
        [JsonProperty("fax")]
        public string Fax { get; set; }

        /// <summary>
        /// A list containing all the store's departments.
        /// </summary>
        [JsonProperty("departments")]
        public List<StoreDepartment> Departments { get; set; }

        /// <summary>
        /// A list containing all the store's services.
        /// </summary>
        [JsonProperty("services")]
        public List<StoreService> Services { get; set; }

        /// <summary>
        /// A list containing all the store's facilities.
        /// </summary>
        [JsonProperty("facilities")]
        public List<StoreFacility> Facilities { get; set; }

    }
}
