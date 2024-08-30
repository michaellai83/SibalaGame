namespace SibalaGame_20240830.Model
{
    public class Parser
    {
        public Parser()
        {
        }

        public List<Player> Parse(string input)
        {
            var playerSections = input.Split("  ", StringSplitOptions.RemoveEmptyEntries);
            var player1Name = GetPlayerName(playerSections, 0);
            var player1Dices = GetPlayerDices(playerSections, 0);

            var player2Name = GetPlayerName(playerSections, 1);
            var player2Dices = GetPlayerDices(playerSections, 1);

            return new List<Player>
                {
                    new Player
                    {
                        Name = player1Name,
                        Dices = player1Dices,
                    },
                    new Player
                    {
                        Name = player2Name,
                        Dices = player2Dices,
                    }
                };
        }

        private static List<Dice> GetPlayerDices(string[] playerSections, int playerIndex)
        {
            return playerSections[playerIndex]
                            .Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(s => new Dice
                            {
                                Value = int.Parse(s),
                                Output = s
                            }).ToList();
        }

        private static string GetPlayerName(string[] playerSections, int playerIndex)
        {
            return playerSections[playerIndex].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
        }
    }
}