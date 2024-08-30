namespace SibalaGame_20240830.Model
{
    public class Parser
    {
        public Parser()
        {
        }

        public List<Player> Parse(string input)
        {
            return new List<Player>
                {
                    new Player
                    {
                        Name = "Black",
                        Dices = new List<Dice>
                        {
                            new Dice{Value = 5, Output = "5"},
                            new Dice{Value = 5, Output = "5"},
                            new Dice{Value = 5, Output = "5"},
                            new Dice{Value = 5, Output = "5"},
                        },
                    },
                    new Player
                    {
                        Name = "White",
                        Dices = new List<Dice>
                        {
                            new Dice{Value = 2, Output = "2"},
                            new Dice{Value = 2, Output = "2"},
                            new Dice{Value = 2, Output = "2"},
                            new Dice{Value = 2, Output = "2"},
                        },
                    }
                };
        }
    }
}