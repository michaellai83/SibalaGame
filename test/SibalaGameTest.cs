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

        [Test]
        public void A03_Both_AllOfAKind_Tie()
        {
            var actual = _game.ShowResult("Black: 3 3 3 3  White: 3 3 3 3");
            actual.Should().Be("Tie.");
        }

        [Test]
        public void A04_Both_AllOfAKind_Black_Win_4VS5()
        {
            var actual = _game.ShowResult("Black: 4 4 4 4  White: 5 5 5 5");
            actual.Should().Be("Black win. - with all of a kind: 4");
        }

        [Test]
        public void A05_Both_AllOfAKind_White_Win_6VS4()
        {
            var actual = _game.ShowResult("Black: 6 6 6 6  White: 4 4 4 4");
            actual.Should().Be("White win. - with all of a kind: 4");
        }

        [Test]
        public void A06_Both_AllOfAKind_Black_Win_1VS4()
        {
            var actual = _game.ShowResult("Black: 1 1 1 1  White: 4 4 4 4");
            actual.Should().Be("Black win. - with all of a kind: 1");
        }

        [Test]
        public void A07_Both_AllOfAKind_White_Win_4VS1()
        {
            var actual = _game.ShowResult("Black: 4 4 4 4  White: 1 1 1 1");
            actual.Should().Be("White win. - with all of a kind: 1");
        }

        [Test]
        public void A08_Both_NormalPoint_Black_Win()
        {
            var actual = _game.ShowResult("Black: 2 6 2 3  White: 5 3 5 4");
            actual.Should().Be("Black win. - with normal point: 9");
        }

        [Test]
        public void A09_Both_NormalPoint_White_Win()
        {
            var actual = _game.ShowResult("Black: 2 1 3 3  White: 2 2 1 3");
            actual.Should().Be("White win. - with normal point: 4");
        }

        [Test]
        public void A10_Both_NormalPoint_Tie()
        {
            var actual = _game.ShowResult("Black: 2 4 2 3  White: 6 4 6 3");
            actual.Should().Be("Tie.");
        }

        [Test]
        public void A11_Both_NormalPoint_Black_Win()
        {
            var actual = _game.ShowResult("Black: 2 4 2 4  White: 2 1 2 3");
            actual.Should().Be("Black win. - with normal point: 8");
        }
    }
}