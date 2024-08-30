using FluentAssertions;

namespace SibalaGame_20240830
{
    public class SibalaGameTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void A01_Both_AllOfAKind()
        {
            var game = new SiblaGame();
            var actual = game.ShowResult("Black: 5 5 5 5  White: 2 2 2 2");
            actual.Should().Be("Black win. - with all of a kind: 5");
        }
    }
}