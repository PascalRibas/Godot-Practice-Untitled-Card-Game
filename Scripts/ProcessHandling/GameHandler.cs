namespace ProcessHandling
{
    public class GameHandler
    {
        private static GameState currentGameState;
        public static void StartMatch(MatchNecessities.Player You, MatchNecessities.Player Opponent)
        {
            currentGameState = new GameState();
            currentGameState.StartGame(You, Opponent);
        }

        //for server communication down the line

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