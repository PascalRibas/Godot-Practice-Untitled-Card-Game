using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UntitledCardGame.Scripts.ProcessHandling
{
    public class GameHandler
    {
        private static GameState currentGameState;
        public static void StartMatch(Player You, Player Opponent)
        {
            currentGameState = new GameState();
            currentGameState.StartGame(You, Opponent);
        }
        
        public static void UpdateGameState(GameState nextGameState)
        {
          currentGameState = nextGameState;
        }

        public static GameState GetGameState()
        {
            return currentGameState;
        }
    }
}