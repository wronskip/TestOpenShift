using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestOpenShift.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceReferenceEBI.getBookXMLResponse1>> Get(int id)
        {
            //ServiceReferenceTemp.ServiceClient client = new ServiceReferenceTemp.ServiceClient();
            //try
            //{
            //    return await client.GetDataAsync(id);
            //}
            //finally

            //{
            //    if (client != null)
            //    {
            //        ((IDisposable)client).Dispose();
            //    }

            //}
         
            ServiceReferenceEBI.WSCitationImplClient client = new ServiceReferenceEBI.WSCitationImplClient();

          

         
            try
            {
                return await client.getBookXMLAsync("1", "1", "1@wp.pl");
            }
            finally

            {
                if (client != null)
                {
                    ((IDisposable)client).Dispose();
                }

            }
            //return "values";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
