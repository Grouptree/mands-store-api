using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandsStoreAPI
{
    /// <summary>
    /// Represents the opening hours of a store on a given week day.
    /// </summary>
    public class StoreOpeningHours: IEquatable<StoreOpeningHours>
    {
        /// <summary>
        /// The day of the week.
        /// </summary>
        [JsonProperty("day")]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The time of the day at which the store opens.
        /// </summary>
        [JsonProperty("open")]
        public string Open { get; set; }

        /// <summary>
        /// The time of the day at which the store closes.
        /// </summary>
        [JsonProperty("close")]
        public string Close { get; set; }

        /// <summary>
        /// Compares two <see cref="StoreOpeningHours"/> instances for equality.
        /// </summary>
        /// <param name="other">The other instance to compare to this one.</param>
        /// <returns><b>true</b> if the two instances are equal; Otherwise, <b>false</b>.</returns>
        public bool Equals(StoreOpeningHours other)
        {
            if (other == null) return false;
            return other.Day == this.Day && other.Open == this.Open && other.Close == this.Close;
        }

        public override bool Equals(object obj)
        {
            var other = obj as StoreOpeningHours;
            if (other != null)
                return Equals(other);
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            var h1 = Day.GetHashCode();
            var h2 = Open.GetHashCode();
            var h3 = Close.GetHashCode();
            var h4 = (((h1 << 5) + h1) ^ h2);
            return (((h4 << 5) + h4) ^ h3);
        }
    }
}
