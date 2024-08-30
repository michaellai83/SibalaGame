namespace SibalaGame_20240830.Model
{
    public class SiblaGame
    {
        public SiblaGame()
        {
        }

        public string ShowResult(string input)
        {
            var parser = new Parser();
            var players = parser.Parse(input);


            var winnerName = players[0].Name;
            var winnerCategory = players[0].Category;
            var winnerOutput = players[0].Dices[0].Output;

            return $"{winnerName} win. - with {winnerCategory}: {winnerOutput}";
        }
    }
}