using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryWebApi.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}