using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryWebApi.Models
{
    public class InventoryItemRepository : IInventoryItemRepository
    {
       
            private List<InventoryItem> items = new List<InventoryItem>();
            private int _nextId = 1;

            public InventoryItemRepository()
            {
                Add(new InventoryItem {Id = 1, Name = "Computers", Description = "Electronics", Price = 15 });
                Add(new InventoryItem {Id = 2, Name = "Sellphones", Description = "Mobile", Price = 12 });
                Add(new InventoryItem {Id = 3, Name = "Camera", Description = "Video", Price = 10 });
            }

            public IEnumerable<InventoryItem> GetAll()
            {
                return items;
            }

            public InventoryItem Get(int id)
            {
                return items.Find(p => p.Id == id);
            }

            public InventoryItem Add(InventoryItem item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                item.Id = _nextId++;
                items.Add(item);
                return item;
            }

            public void Remove(int id)
            {
               items.RemoveAll(p => p.Id == id);
            }

            public bool Update(InventoryItem item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                int index = items.FindIndex(p => p.Id == item.Id);
                if (index == -1)
                {
                    return false;
                }
                    items.RemoveAt(index);
                    items.Add(item);
                return true;
            }
        }
    }

