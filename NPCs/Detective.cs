using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _gameDev1.NPCs
{
    public class Detective : INPC
    {
        public string Name => "Detective Jacob";
        public string[] Dialog { get; } =
        {
            "Hello, I am Jacob, who will be working alongside you.",
            "I have some information that might prove valuable to the investigation"
        };

        public void Interact(string action)
        {
            if(action.ToLower().Contains("murder"))
            {
                Console.WriteLine("The suspect was wearing a black trench coat with a suit, around 170cm tall");
                Console.WriteLine("The murder happened on the fifth of October, and the body was found 10 hours later");
                Console.WriteLine("You should ask the suspects about what they were doing that day");
                Console.WriteLine("That's all the information I have");
            }
            else
            {
                Console.WriteLine("I don't have any information on that");
            }
        }
    }
}
