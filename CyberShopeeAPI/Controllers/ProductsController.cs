using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CyberShopeeAPI.Models;

namespace CyberShopeeAPI.Controllers
{
    public class ProductsController : ApiController
    {
        CyberShopeeEntities db = new CyberShopeeEntities();

        [HttpGet]
        // method to get product details by Product ID
        public List<Product> GetProductById([FromUri]int _productId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var result = db.Products.Where(c => c.ProductId == _productId).ToList();
            if (result.Count > 0)
                return result;
            return  null;
        }

        [HttpGet]
        // Method to get products by rating above 4.5
        public List<Product> GetProductByRating()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var result = db.Products.Where(c => c.Rating >= 4.5).ToList();
            if (result.Count > 0)
                return result;
            return null;
        }
    }
}
