using FluentAssertions;
using SibalaGame_20240830.Model;

namespace SibalaGame_20240830.test
{
    public class SibalaGameTest
    {
        private SiblaGame _game;

        [SetUp]
        public void Setup()
        {
            _game = new SiblaGame();
        }

        [Test]
        public void A01_Both_AllOfAKind_Black_Win()
        {        
            var actual = _game.ShowResult("Black: 5 5 5 5  White: 2 2 2 2");
            actual.Should().Be("Black win. - with all of a kind: 5");
        }

        [Test]
        public void A02_Both_AllOfAKind_White_Win()
        {
            var actual = _game.ShowResult("Black: 3 3 3 3  White: 6 6 6 6");
            actual.Should().Be("White win. - with all of a kind: 6");
        }
    }
}