using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace _gameDev1
{
    internal class NPC_Manager
    {
        public List<NPC> NPCs;

        public NPC_Manager() 
        { 
            NPCs = new List<NPC>();
            InitNPCs();
        }

        public void InitNPCs()
        {
            NPCs.Add(new NPC("Witness John", "The culprit was wearing a tall, dark coat. He was running away from the scene."));
            NPCs.Add(new NPC("Sarah, the wife", "He must have made alot of enemies in his time rising to fame"));
        }

        public void Random_Encounter()
        {
            Random _random = new Random();
            int RandomIndex = _random.Next(NPCs.Count);
            NPC _randomNPC = NPCs[RandomIndex];
            _randomNPC.StartEncounter();
        }
    }
}
