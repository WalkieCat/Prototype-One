using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _gameDev1.Action;

namespace _gameDev1
{
    class GameMechanics
    {
        private _intro Intro;
        private _player Player1;
        private _inventory Player1_Inventory;
        // Mapping actions 
        private Dictionary<string, Action<string>> commandActions;
        private Dictionary<string, IAction> actions;

        public GameMechanics(_player Player1)
        {
            Intro = new _intro(this);
            this.Player1 = Player1;
            Player1_Inventory = new _inventory();
            Player1_Inventory.AddInitialItems();

            // Initialize the dictionary with command-action mappings
            InitMovingActions();
            InitActions();
        }

        public void Start()
        {
            Intro._introDisplay(Player1);
        }

        public void Gameplay()
        {
            while (true) 
            {
                Console.WriteLine("Enter your action: ");
                string action = Console.ReadLine();

                //ProccessMovingAction(action);
                ProcessPlayerAction(action);
            }
        }

        //Action method
        private void InitActions()
        {
            actions = new Dictionary<string, IAction>
            {
                {"quit", new QuitAction() },
                {"inventory", new InventoryAction(Player1_Inventory) },
                {"view inventory", new InventoryAction(Player1_Inventory) },
            };
        }
        public void ProcessPlayerAction(string action)
        {
            // Convert to lower case for comparisons
            string trimmedAction = action.Trim().ToLower();

            // Check if the action contains the word "move"
            if (trimmedAction.StartsWith("move"))
            {
                ProcessMovingAction(action);
            }
            else
            {
                PerformPlayerAction(trimmedAction);
            }
        }

        private void PerformPlayerAction(string action)
        {
            if (actions.ContainsKey(action))
            {
                actions[action].Execute();
            }
            else
            {
                Console.WriteLine("It does not seem like you can do that right now\n");
            }
        }


        //Movement method
        private void InitMovingActions()
        {
            commandActions = new Dictionary<string, Action<string>>()
            {
                { "move", MoveTo },
                // Adding more commands to corresponds to movement actions
            };
        }

        public void ProcessMovingAction(string action)
        {
            // Split the input into command and action
            string[] actionParts = action.Split(new[] { ' ' }, 2);
            if (actionParts.Length >= 2)
            {
                string command = actionParts[0].Trim().ToLower();
                string destination = actionParts[1].Trim();

                // Perform actions based on commands and/or destination
                if (commandActions.ContainsKey(command))
                {
                    commandActions[command].Invoke(destination);
                }
                else
                {
                    Console.WriteLine($"You cannot {command} to {destination} right now\n");
                }
            }
        }

        public void MoveTo(string destination)
        {
            //Logic to be implemented
            Console.WriteLine($"Moving to {destination}\n");
        }
    }
}
