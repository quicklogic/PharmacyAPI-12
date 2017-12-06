using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PharmacyAPI.Controllers
{
    public class ImageController : ApiController
    {
        Pharmacy db = new Pharmacy();
        

        public IEnumerable<Image> Get()
        {
            return db.Images.ToList();
        }

        public Image Get(int ID)
        {
                            return db.Images.Where(p => p.ProductID == ID).FirstOrDefault();
       
        }
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}