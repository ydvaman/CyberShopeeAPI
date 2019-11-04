using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CyberShopeeAPI.Models;

namespace CyberShopeeAPI.Controllers
{
    public class CustomerController : ApiController
    {

        CyberShopeeEntities db = new CyberShopeeEntities();
        [HttpPost]
        public IHttpActionResult PostSignIn(Customer customer)
        {
            var result = db.Customers.Where(c => c.Username == customer.Username).Where(c => c.Password == customer.Password).ToList();
            if (result.Count > 0)
                return Ok();
            return NotFound();
        }


    }
}
