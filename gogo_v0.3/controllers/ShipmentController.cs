using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gogo_v0._3.controllers
{
    public class ShipmentController : ApiController
    {
        // GET: api/Shipment
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Shipment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shipment
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Shipment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shipment/5
        public void Delete(int id)
        {
        }
    }
}
