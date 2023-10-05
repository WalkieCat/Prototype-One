using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _gameDev1.Action
{
    public class QuitAction : IAction
    {
        public void Execute()
        {
            Console.WriteLine("Quitting the game. Goodbye!");
            Environment.Exit(0);
        }
    }
}