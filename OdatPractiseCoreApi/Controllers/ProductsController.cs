using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdatPractiseCoreApi.Domain;
using OdatPractiseCoreApi.Models;

namespace OdatPractiseCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductDomain domain = new ProductDomain();

        [HttpGet]
        [EnableQuery]
        public IQueryable<Product> Get()
        {
            return domain.Products.AsQueryable();
        }
    }
}