using Microsoft.AspNet.OData;
using OdataPractiseApi.Domain;
using OdataPractiseApi.Models;
using System.Linq;
using System.Web.Http;

namespace OdataPractiseApi.Controllers
{
    public class ProductsController : ODataController
    {
        ProductDomain domain = new ProductDomain();

        [EnableQuery]
        public IQueryable<Product> Get()
        {
            return domain.Products.AsQueryable();
        }
        [EnableQuery]
        public SingleResult<Product> Get([FromODataUri] int key)
        {
            IQueryable<Product> result = domain.Products.Where(p => p.EntityID == key).AsQueryable();
            return SingleResult.Create(result);
        }
    }
}
