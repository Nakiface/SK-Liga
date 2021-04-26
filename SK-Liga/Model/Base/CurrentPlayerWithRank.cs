namespace SK_Liga.Model.Base
{
    public class CurrentPlayerWithRank : CurrentPlayer
    {
        public int Rank { get; set; }

        public CurrentPlayerWithRank(string name, int elo, int rank)
        {
            base.Name = name;
            base.CurrentElo = elo;
            this.Rank = rank;
        }
    }
}
