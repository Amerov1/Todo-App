using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp_Mon_.Services
{
    public interface IItemService
    {
        void add(Item item);

        void update(Item item);
        void delete(int id);
        Item getItemById(int id);
        void deleteAllDoneItems(List<Item> items);
        List<Item> getItems();
        

        
        
            
                
    }
}
