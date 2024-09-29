using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_create.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<MockProduct> GetProductList()
        {
            List<MockProduct> MockProducts = new List<MockProduct>();
            MockProduct mp = new MockProduct();
            mp.ID = 1;
            mp.ProductName = "one";
            MockProducts.Add(mp);
            return MockProducts;
        }
        [HttpPost]
        public IHttpActionResult UpdateProduct([FromBody] MockProduct MockProduct)
        {
            //some code(to be added later)
            return Ok();
        }
    }
    public class MockProduct
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
    }
}
