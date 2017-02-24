using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventoryWebApi.Models;

namespace InventoryWebApi.Services
{
    public class ItemRepository
    {
        //private const string CacheKey = "StoreInventory";

        //public ItemRepository()
        //{
        //    var ctx = HttpContext.Current;

        //    if (ctx != null)
        //    {
        //        if (ctx.Cache[CacheKey] == null)
        //        {
        //            var items = new Item[]
        //    {
        //            new Item
        //            {
        //                ItemId = 1, Name = "iPhone", Description="7 plus", Price = 15
        //            },
        //            new Item
        //            {
        //                ItemId = 2, Name = "iPod", Description="touch", Price = 14
        //            }
        //            ,
        //            new Item
        //            {
        //                ItemId = 3, Name = "iPad", Description = "mini", Price = 17
        //            }
        //    };

        //            ctx.Cache[CacheKey] = items;
        //        }
        //    }
        //}

        //internal static object Where(Func<object, bool> p)
        //{
        //    throw new NotImplementedException();
        //}

        //public Item[] GetAllItems()
        //{
        //    var ctx = HttpContext.Current;

        //    if (ctx != null)
        //    {
        //        return (Item[]) ctx.Cache[CacheKey];
        //    }

        //    return new Item[]
        //    {
        //        new Item
        //        {
        //            ItemId = 0,
        //            Name = "Placeholder"
        //        }
        //    };
        //}

        //public bool SaveItem(Item item)
        //{
        //    var ctx = HttpContext.Current;

        //    if (ctx != null)
        //    {
        //        try
        //        {
        //            var currentData = ((Item[]) ctx.Cache[CacheKey]).ToList();
        //            currentData.Add(item);
        //            ctx.Cache[CacheKey] = currentData.ToArray();

        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.ToString());
        //            return false;
        //        }
        //    }

        //    return false;
        //}

    }
}