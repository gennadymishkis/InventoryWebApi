using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventoryWebApi;
using InventoryWebApi.Controllers;
using InventoryWebApi.Models;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace InventoryWebApi.Tests.Controllers
{
    public class InventoryItemControllerTest
    {
       
        [TestMethod]
        public void GetAllItems_ShouldReturnAllItems()
        {
            var testItems = GetTestItems();
            var controller = new InventoryItemController(testItems);

            var result = controller.GetAllItems() as List<InventoryItem>;
            Assert.AreEqual(testItems.Count, result.Count);
        }

        //[TestMethod]
        //public async Task GetAllItemsAsync_ShouldReturnAllItems()
        //{
        //    var testItems = GetTestItems();
        //    var controller = new InventoryItemController(testItems);

        //    var result = await controller.GetAllItemsAsync() as List<InventoryItem>;
        //    Assert.AreEqual(testItems.Count, result.Count);
        //}

        [TestMethod]
        public void GetItem_ShouldReturnCorrectItem()
        {
            var testItems = GetTestItems();
            var controller = new InventoryItemController(testItems);

            var result = controller.GetItem(3) as OkNegotiatedContentResult<InventoryItem>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testItems[3].Name, result.Content.Name);
        }

        //[TestMethod]
        //public async Task GetProductAsync_ShouldReturnCorrectItem()
        //{
        //    var testItems = GetTestItems();
        //    var controller = new InventoryItemController(testItems);

        //    var result = await controller.GetItemAsync(4) as OkNegotiatedContentResult<InventoryItem>;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(testItems[3].Name, result.Content.Name);
        //}

        [TestMethod]
        public void GetItem_ShouldNotFindItem()
        {
            var controller = new InventoryItemController(GetTestItems());

            var result = controller.GetItem(999);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        public List<InventoryItem> GetTestItems()
        {
            var testItems = new List<InventoryItem>();
            testItems.Add(new InventoryItem { Id = 1, Name = "Computers", Description = "Electronics", Price = 15 });
            testItems.Add(new InventoryItem { Id = 2, Name = "Sellphones", Description = "Mobile", Price = 12 });
            testItems.Add(new InventoryItem { Id = 3, Name = "Camera", Description = "Mobile", Price = 10 });

            return testItems;
        }

    }
}
