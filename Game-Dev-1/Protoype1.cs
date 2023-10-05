using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _gameDev1
{
    class Protoype1
    {
        public static _player Player1 = new _player();
        static void Main(string[] args) 
        {
            _startMenu();
            GameMechanics _game = new GameMechanics(Player1);
            _game.Start();

        }

        static void _startMenu()
        {
            Console.WriteLine("Welcome to Prototype 1!");
            while (string.IsNullOrEmpty(Player1.Name)) 
            {
                Console.WriteLine("Enter your character name: ");
                Player1.Name = Console.ReadLine().Trim();

                if (Player1.Name == "")
                {
                    Console.WriteLine("Please enter your name!");
                }
            }
            Console.Clear();
        }
    }
}