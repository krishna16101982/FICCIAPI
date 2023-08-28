using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [Route("get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

         [Route("get2")]
        public IEnumerable<string> Get2()
        {
            return new string[] { "kumar", "gaurav" };
        }
        [Route("get/{id}")]
        // GET: api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/values/5
        public void Delete(int id)
        {
        }
    }
}