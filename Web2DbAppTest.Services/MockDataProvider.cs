using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web2DbAppTest.Entities;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Web2DbAppTest.Services
{

    /// <summary>
    /// Handles the data you get from an API(randomuser.me)
    /// </summary>
    public class MockDataProvider
    {
        /// <summary>The url</summary>
        private string url = "https://randomuser.me/api/?results=";

        /// <summary>
        /// Gets user data from API
        /// </summary>
        /// <param name="amount">The amount of users you want</param>
        /// <returns>List<Person> filled with all the data from the API</returns>
        public List<Person> GetPeople(int amount)
        {
            List<Person> persons = new List<Person>();
            WebClient wc = new WebClient();
            string respone = wc.DownloadString(url + amount);
            JObject jsonRespone = JObject.Parse(respone);

            for (int i = 0; i < amount; i++)
            {
                JObject name = (JObject)jsonRespone["results"][i]["name"];
                JToken firstname = name["first"];
                JToken lastname = name["last"];
                JToken titleOfCourtesy = name["title"];
                persons.Add(new Person(firstname.ToString(), lastname.ToString(), titleOfCourtesy.ToString()));
            }
            return persons;
        }
    }
}
