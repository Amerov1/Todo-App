using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618, CS8766
namespace BlazorApp_Mon_.Services
{

    public class ItemService : IItemService
    {
        public List<Item> items { get; set; }

        public ItemService() { items = new List<Item>(); }
        public void add(Item item)
        {

            if (items.Count == 0)
                item.Id = 0;
            else
                item.Id = items.OrderByDescending(x => x.Id).First().Id + 1;
            items.Add(item);
        }
        public void update(Item item)
        {
            delete(item.Id);
            items.Add(item);
        }
        public void delete(int id)
        {
            items = items.Where(x => x.Id != id).ToList();
        }

        public Item? getItemById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);

        }
        public void deleteAllDoneItems(List<Item> items)
        {
            foreach (var item in items)
                if (item.IsDone)
                {
                    items.Remove(item);
                }
        }
        public List<Item> getItems()
        {
          items=  items.OrderBy(x => x.Id).ToList();
            return items;
        }
    }
}
