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
            Player playerOne;
            Player playerTwo;
            public Game()
        {
            this.playerOne = SetUpPlayerOne();
            this.playerTwo = Game_Type();
        }


            public void RunGame()
        {
            Game_Rules();
            Play_Game();
        }
            public static Player SetUpPlayerOne()
            {
                Player playerOne;
                Console.WriteLine(" Player One's name?: ");
                string name = Console.ReadLine();
                playerOne = new Human(name, 0, "none");
                return playerOne;

            }

            public Player Game_Type()
            {

            }


            public void Game_Rules()
            {

            }
            public void Play_Game()
            {

            }

            public void RoundWinner(string Player1Gesture, string Play22Gesture)
            {
                

    }
}
