namespace SibalaGame_20240830.Model
{
    public class Player
    {
        public string Name { get; internal set; }
        public List<Dice> Dices { get; internal set; }
        public string Category { get; internal set; }
    }
}