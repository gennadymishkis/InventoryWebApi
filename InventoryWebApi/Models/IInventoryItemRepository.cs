using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryWebApi.Models
{
    public interface IInventoryItemRepository
    {
        IEnumerable<InventoryItem> GetAll();
        InventoryItem Get(int id);
        InventoryItem Add(InventoryItem item);
        void Remove(int id);
        bool Update(InventoryItem item);
    }
}
