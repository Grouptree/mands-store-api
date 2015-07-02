using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandsStoreAPI;

namespace MandStoreAPI.Test
{
    /*
     *
     * The test below is intended as a sanity check only.
     *
     * It's dependent on a network connection and on the specific data being
     * available at the API at the time it is run.
     *
     */

    [TestFixture(Description = "MandsStoreApiClient class")]
    [Category("Network")]
    public class APITest
    {
        static readonly string TestApiKey = ConfigurationManager.AppSettings["apiKey"];
        static readonly string TestApiSecret = ConfigurationManager.AppSettings["apiSecret"];

        [Test(Description = "GetStoreInfo() method")]
        public async Task TestGetStoreInfo()
        {
            var client = new MandsStoreApiClient(TestApiKey, TestApiSecret);
            var store = await client.GetStoreInfo("10");
            Assert.AreEqual("THURROCK OUTLET", store.Name);
            Assert.AreEqual(10, store.Id);
            Assert.AreEqual("mands", store.StoreType);
            Assert.AreEqual(51.485931m, store.Coordinates.Latitude);
            Assert.AreEqual(0.271349m,store.Coordinates.Longitude);
            var expectedOpeningHours = new StoreOpeningHours[] {
                new StoreOpeningHours { Day = DayOfWeek.Monday, Open = "09:00", Close = "21:00" },
                new StoreOpeningHours { Day = DayOfWeek.Tuesday, Open = "09:00", Close = "21:00" },
                new StoreOpeningHours { Day = DayOfWeek.Wednesday, Open = "09:00", Close = "21:00" },
                new StoreOpeningHours { Day = DayOfWeek.Thursday, Open = "09:00", Close = "21:00" },
                new StoreOpeningHours { Day = DayOfWeek.Friday, Open = "09:00", Close = "21:00" },
                new StoreOpeningHours { Day = DayOfWeek.Saturday, Open = "09:00", Close = "20:00" },
                new StoreOpeningHours { Day = DayOfWeek.Sunday, Open = "11:00", Close = "17:00" },
            };
            CollectionAssert.AreEqual(expectedOpeningHours, store.CoreOpeningHours);
            CollectionAssert.IsEmpty(store.SpecialOpeningHours);
            Assert.AreEqual("THURROCK OUTLET", store.Address.Line1);
            Assert.AreEqual("Unit 6  The Junction Retail Park", store.Address.Line2);
            Assert.AreEqual("THURROCK", store.Address.City);
            Assert.AreEqual("KK", store.Address.County);
            Assert.AreEqual("GB", store.Address.CountryCode);
            Assert.AreEqual("United Kingdom", store.Address.CountryName);
            Assert.AreEqual("RM20 3LP", store.Address.PostalCode);
            Assert.AreEqual("(01708) 862557", store.Phone);
            Assert.AreEqual("", store.Fax);
            CollectionAssert.IsEmpty(store.Departments);
            CollectionAssert.IsEmpty(store.Services);
            CollectionAssert.IsEmpty(store.Facilities);
        }
    }
}
