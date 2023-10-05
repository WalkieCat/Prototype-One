using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _gameDev1
{
    public class _inventory
    {
        private List<string> Items;
        public _inventory()
        {
            Items = new List<string>();
        }


        public void AddItem(string item) 
        {
            Items.Add(item);
            Console.WriteLine($"Added {item} in your inventory");

        }

        public void AddInitialItems()
        {
            // Add initial items
            AddItem("Notes");
            AddItem("Car key");
            AddItem("Gun");
            AddItem("Map");
        }

        public void RemoveItem(string item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                Console.WriteLine($"You have discarded {item} from your inventory\n");
            }
            else
            {
                Console.WriteLine("You don't have the item in your inventory\n");
            }
        }

        public void ViewInventory()
        {
            Console.WriteLine("Inventory: ");
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }

    }
}
