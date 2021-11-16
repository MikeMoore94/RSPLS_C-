using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_C
{
    internal class Game
    {
        Player playerOne;
        Player playerTwo;
        public Game()
        {
            this.playerOne = SetUpPlayerOne();
            this.playerTwo = ChooseGameType();
        }

        public void RunGame()
        {
            WelcomeMessage();
            DisplayRules();
            PlayGame();
        }
    }
}
