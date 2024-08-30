namespace SibalaGame_20240830.Model
{
    public class SiblaGame
    {
        public Dictionary<int, int> _AllOfAKindLookup = new Dictionary<int, int>
        {
            {1,6},
            {4,5},
            {6,4},
            {5,3},
            {3,2},
            {2,1},
        };
        public SiblaGame()
        {
        }

        public string ShowResult(string input)
        {
            var parser = new Parser();
            var players = parser.Parse(input);

            var player1 = players[0];
            var player2 = players[1];

            var winner = player1;

            if (player1.Dices[0].Value == player2.Dices[0].Value)
            {
                return "Tie.";
            }

            if (_AllOfAKindLookup[player2.Dices[0].Value] > _AllOfAKindLookup[player1.Dices[0].Value])
            {
                winner = player2;
            }

            return $"{winner.Name} win. - with {winner.Category}: {winner.Dices[0].Output}";
        }
    }
}