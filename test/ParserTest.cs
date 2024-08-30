using FluentAssertions;
using SibalaGame_20240830.Model;

namespace SibalaGame_20240830.test
{
    public class ParserTest
    {
        [Test]
        public void B01_GetPlayerResult()
        {
            var target = new Parser();
            var actual = target.Parse("Black: 5 5 5 5  White: 2 2 2 2");
            actual.Should().BeEquivalentTo(
                new List<Player>
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
                });
        }
    }
}
