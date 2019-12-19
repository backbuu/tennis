using TennisLib;
using Xunit;

namespace TennisTest
{
    public class TennisTest
    {
        [Fact]
        public void InitialGameScoreShouldBeLoveLove()
        {
            var game = new Tennis();

            var score = game.Score();

            Assert.Equal("LOVE-LOVE", score);
        }

        [Fact]
        public void AGetFirstPointScoreShouldBe15_Love()
        {
            var game = new Tennis();

            game.AGetPoint();
            var score = game.Score();

            Assert.Equal("15-LOVE", score);
        }

        [Fact]
        public void AGetSecondPointScoreShouldBe30_Love()
        {
            var game = new Tennis();
            game.AGetPoint();
            game.AGetPoint();
            var score = game.Score();

            Assert.Equal("30-LOVE", score);
        }
        [Fact]
        public void AGetThirdPointScoreShouldBe40_Love()
        {
            var game = new Tennis();
            game.AGetPoint();
            game.AGetPoint();
            game.AGetPoint();
            var score = game.Score();

            Assert.Equal("40-LOVE", score);
        }

        [Fact]
        public void BGetFirstPointScoreShouldBeLove_15()
        {
            var game = new Tennis();

            game.BGetPoint();
            var score = game.Score();

            Assert.Equal("LOVE-15", score);
        }
        [Fact]
        public void AGetForthPointScoreShouldBeWinForA()
        {
            var game = new Tennis();

            game.AGetPoint();
            game.AGetPoint();
            game.AGetPoint();
            game.AGetPoint();
            var score = game.Score();

            Assert.Equal("WIN FOR A", score);
        }
    }
}
