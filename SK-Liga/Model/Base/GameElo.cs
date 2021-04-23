namespace SK_Liga.Model.Base
{
    public class GameElo
    {
        public Game Game { get; private set; }
        public int Elo { get; private set; }
        public GameElo (Game game, int elo)
        {
            this.Game = game;
            this.Elo = elo;
        }
    }
}
