using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _gameDev1.NPCs
{
    public interface INPC
    {
        string Name { get; }
        string[] Dialog { get; }

        void Interact(string action);
    }
}
