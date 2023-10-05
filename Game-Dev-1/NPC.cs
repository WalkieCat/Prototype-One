using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _gameDev1
{
    internal class NPC
    {
        public string Character_Name { get; }
        public string Encouter_Dialogue { get; set; }

        public NPC(string charName, string dialogue)
        {
            Character_Name = charName;
            Encouter_Dialogue = dialogue;

        }

        public void StartEncounter()
        {
            Console.WriteLine($"You have met {Character_Name}");
            Console.WriteLine(Encouter_Dialogue);
        }

        public void SetDialogue(string newDialogue)
        {
            Encouter_Dialogue = newDialogue;
        }
    }
}
