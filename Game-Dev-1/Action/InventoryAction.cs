using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _gameDev1.Action;

namespace _gameDev1.Action
{
    public class InventoryAction : IAction
    {
        private _inventory Player1_Inventory;

        public InventoryAction(_inventory player1_Inventory)
        {
            Player1_Inventory = player1_Inventory;
        }

        public void Execute()
        {
            Player1_Inventory.ViewInventory();
        }
    }
}
