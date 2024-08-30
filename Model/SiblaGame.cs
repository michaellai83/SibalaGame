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

            var player1 = players[0];
            var player2 = players[1];

            var player1DicesPoint = player1.Dices[0].Value;
            var player2DicesPoint = player2.Dices[0].Value;

            var winnerName = player1.Name;
            var winnerCategory = player1.Category;
            var winnerOutput = player1.Dices[0].Output;

            if(player1DicesPoint == player2DicesPoint)
            {
                return "Tie.";
            }

            if (player2DicesPoint >  player1DicesPoint)
            {
                winnerName = player2.Name;
                winnerCategory = player2.Category;
                winnerOutput = player2.Dices[0].Output;
            }
            
            return $"{winnerName} win. - with {winnerCategory}: {winnerOutput}";
        }
    }
}