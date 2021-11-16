using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_C
{
    internal class Human
    {
        public Human(string name, int score, string gesture)
        {
            this.name = name;
            this.score = score;
            this.gesture = gesture;
        }

        public override string ChooseGesture()
        {
            Console.WriteLine("Attack!: 1 = Rock, 2 = Paper, 3 = Scissors, 4 = Lizard, and 5 = Spock");
            int gesture = Convert.ToInt32(Console.ReadLine()) - 1;
            return this.gestureList[gesture];

        }
    }
}
