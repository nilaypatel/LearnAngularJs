using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/product
        private Product[] products = 
        {
            new Product{ Id = 1, Name = "Product 1", Price = (decimal) 11.12d },
            new Product{ Id = 2, Name = "Product 2", Price = (decimal) 10.23d },
            new Product{ Id = 3, Name = "Product 3", Price = (decimal) 1.92d },
            new Product{ Id = 4, Name = "Product 4", Price = (decimal) 15.22d },
            new Product{ Id = 5, Name = "Product 5", Price = (decimal) 18.24d },
        };


        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/product/5
        public IHttpActionResult Get(int id)
        {
            var product = products.SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/product
        public void Post([FromBody]string value)
        {
        }

        // PUT api/product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/product/5
        public void Delete(int id)
        {
        }
    }
}
