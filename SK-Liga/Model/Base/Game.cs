namespace SK_Liga.Model.Base
{
    public class Game
    {
        public string Name { get; internal set; }
        public Game(string gameName)
        {
            this.Name = gameName;
        }
    }
}
