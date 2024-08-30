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
                        Category = "all of a kind",
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
                        Category = "all of a kind",
                    }
                });
        }

        [Test]
        public void B02_GetPlayerCategory_NormalPointVSAllOfAKind()
        {
            var target = new Parser();
            var actual = target.Parse("Black: 5 1 5 2  White: 2 2 2 2");
            actual.Should().BeEquivalentTo(
                new List<Player>
                {
                    new Player
                    {
                        Name = "Black",
                        Dices = new List<Dice>
                        {
                            new Dice{Value = 5, Output = "5"},
                            new Dice{Value = 1, Output = "1"},
                            new Dice{Value = 5, Output = "5"},
                            new Dice{Value = 2, Output = "2"},
                        },
                        Category = "normal point",
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
                        Category = "all of a kind",
                    }
                });
        }

        [Test]
        public void B03_GetPlayerCategory_NormalPointVSNoPoint()
        {
            var target = new Parser();
            var actual = target.Parse("Black: 5 1 5 2  White: 2 2 2 5");
            actual.Should().BeEquivalentTo(
                new List<Player>
                {
                    new Player
                    {
                        Name = "Black",
                        Dices = new List<Dice>
                        {
                            new Dice{Value = 5, Output = "5"},
                            new Dice{Value = 1, Output = "1"},
                            new Dice{Value = 5, Output = "5"},
                            new Dice{Value = 2, Output = "2"},
                        },
                        Category = "normal point",
                    },
                    new Player
                    {
                        Name = "White",
                        Dices = new List<Dice>
                        {
                            new Dice{Value = 2, Output = "2"},
                            new Dice{Value = 2, Output = "2"},
                            new Dice{Value = 2, Output = "2"},
                            new Dice{Value = 5, Output = "5"},
                        },
                        Category = "no point",
                    }
                });
        }
    }
}
