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
            var result = new List<Player>();

            foreach (var playerSection in playerSections)
            {
                var player = new Player
                {
                    Name = GetPlayerName(playerSection),
                    Dices = GetPlayerDices(playerSection),
                };
                result.Add(player);
            }

            return result;
        }

        private static List<Dice> GetPlayerDices(string playerSection)
        {
            return playerSection
                .Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => new Dice
                {
                    Value = int.Parse(s),
                    Output = s
                }).ToList();
        }

        private static string GetPlayerName(string playerSection)
        {
            return playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
        }
    }
}