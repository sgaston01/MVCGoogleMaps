using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCGoogleMaps.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {

            string json = "{}";

            if (id == 1)
            json = "{\"lat\":36.169483, \"lng\":-115.1440113}";
 
            if (id == 2)
            json = "{\"h\":{\"lat\":36.169483, \"lng\":-115.1440113}}";

            if (id == 3)
            json = "{\"h\":{\"lat\":36.1695146 \"lng\":-115.1442877}}";

            if (id == 4)
            json = "{\"h\":{\"lat\":36.1706918, \"lng\":-115.1455689}}";

            if (id == 5)
            json = "{\"h\":{\"lat\":36.1709685, \"lng\":-115.147562}}";

            json = "[{\"lat\":36.169483, \"lng\":-115.1440113}]";

            return json;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
