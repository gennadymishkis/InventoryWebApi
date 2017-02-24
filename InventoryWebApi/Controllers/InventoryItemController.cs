using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InventoryWebApi.Models;
using System.Threading.Tasks;

namespace InventoryWebApi.Controllers
{
    [RoutePrefix("api/InventoryItem")]
    public class InventoryItemController : ApiController
    {
        static readonly IInventoryItemRepository repository = new InventoryItemRepository();

        List<InventoryItem> items = new List<InventoryItem>();

        public InventoryItemController() { }

        public InventoryItemController(List<InventoryItem> items)
        {
            this.items = items;
        }


        public IEnumerable<InventoryItem> GetAllItems()
        {
            return repository.GetAll();
        }

        //public async Task<IEnumerable<InventoryItem>> GetAllItemsAsync()
        //{
        //    return await Task.FromResult(GetAllItems());
        //}

        public IHttpActionResult GetItem(int id)
        {
            InventoryItem item = repository.GetAll().FirstOrDefault((p) => p.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);

        }
        public IHttpActionResult GetItemByName(string name)
        {
            InventoryItem item = repository.GetAll().FirstOrDefault((p) => p.Name == name);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        //public async Task<IHttpActionResult> GetItemAsync(int id)
        //{
        //    return await Task.FromResult(GetItem(id));
        //}

        public IEnumerable<InventoryItem> GetItemsByName(string name)
        {
            return repository.GetAll().Where(
                p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
        }

        

        public HttpResponseMessage PostItem(InventoryItem item)
        {
            item = repository.Add(item);
            HttpResponseMessage response = Request.CreateResponse<InventoryItem>(HttpStatusCode.Created, item);

            string uri = Url.Link(routeName: "DefaultApi", routeValues: new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutItem(int id, InventoryItem item)
        {
            item.Id = id;
            if (!repository.Update(item))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeleteProduct(int id)
        {
            InventoryItem item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Remove(id);
        }

        private double ItemTotal(ShoppingCart cart)
        {
            var item = repository.GetAll().Where(x => x.Id == cart.ItemId).First();
         
            if (item == null)
                return 0;

            return item.Price * cart.Qty;
        }

        [HttpPost]
        [Route("GetTotal")]
        public double GetTotal(List<ShoppingCart> cart)
        {
            double total = 0;
            foreach (ShoppingCart item in cart)
            {
                total += ItemTotal(item);
            }
            return total;
        }
    }
}
