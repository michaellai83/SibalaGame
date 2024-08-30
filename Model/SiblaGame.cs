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

            var winner = DetermineWinner(player1, player2);

            if (winner == null)
            {
                return "Tie.";
            }

            if (IsAllOfAKind(winner))
            {
                return $"{winner.Name} win. - with {winner.Category}: {winner.Dices[0].Output}";
            }


            return $"{winner.Name} win. - with {winner.Category}: {winner.Dices[2].Value + winner.Dices[3].Value}";
        }

        private Player DetermineWinner(Player player1, Player player2)
        {
            if (IsAllOfAKind(player1) || IsAllOfAKind(player2))
            {
                return CompareAllOfAKind(player1, player2);
            }

            return CompareSumAndHighestDice(player1, player2);
        }

        private bool IsAllOfAKind(Player player) => player.Category == "all of a kind";

        private Player CompareAllOfAKind(Player player1, Player player2)
        {
            if (player1.Category == player2.Category)
            {
                if (player1.Dices[0].Value == player2.Dices[0].Value)
                {
                    return null; // Tie
                }

                return _AllOfAKindLookup[player2.Dices[0].Value] > _AllOfAKindLookup[player1.Dices[0].Value]
                    ? player2
                    : player1;
            }

            return player2.Category == "all of a kind" ? player2 : player1;
        }

        private Player CompareSumAndHighestDice(Player player1, Player player2)
        {
            var player1Sum = player1.Dices[2].Value + player1.Dices[3].Value;
            var player2Sum = player2.Dices[2].Value + player2.Dices[3].Value;

            if (player1Sum == player2Sum)
            {
                return player2.Dices[3].Value > player1.Dices[3].Value ? player2 : null; // Tie if player1.Dices[3].Value >= player2.Dices[3].Value
            }

            return player2Sum > player1Sum ? player2 : player1;
        }
    }
}