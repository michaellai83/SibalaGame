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
                player.Category = GetGameCategory(player.Dices);

                result.Add(player);
            }

            return result;
        }

        private static string GetGameCategory(List<Dice> dices)
        {
            var gameCategory = "no point";

            if (dices.All(d => d.Value == dices[0].Value))
            {
                gameCategory = "all of a kind";
            }
            else if (dices.GroupBy(x => x.Value).Any(x => x.Count() == 2))
            {
                gameCategory = "normal point";
            }

            return gameCategory;
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
                }).GroupBy(d => d.Value)
                  .OrderByDescending(g => g.Count())
                  .ThenBy(g => g.Key)
                  .SelectMany(g => g)
                  .ToList();
        }

        private static string GetPlayerName(string playerSection)
        {
            return playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
        }
    }
}