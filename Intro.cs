using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _gameDev1
{
    class _intro
    {
        // Implement mechanics to process actions
        public GameMechanics gameMechanics;
        public _intro(GameMechanics gameMechanics)
        {
            this.gameMechanics = gameMechanics;
        }
        public void _introDisplay(_player Player1)
        {
            string IntroText = $@"
            You are {Player1.Name}, aged {Player1.Age}, the newly appointed detective of Point Hope. 

            Your first case on the job is the murder of Mr. Benjamin, a high profile character

            that rose to fame through exploitations and backstabbing. Regardless, your job as a detective

            is to bring justice to the family. With vague reports and witnesses testimony, will you find the truth,

            or die trying? You sit in your office, thinking.

            What is your first move?
            ";

            Console.WriteLine(IntroText);

            // Start the gameplay
            gameMechanics.Gameplay();
        }
    }
}
