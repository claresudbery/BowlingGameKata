
using NUnit.Framework;

namespace BowlingGameKata
{
    [TestFixture]
    public class BowlingGameTests
    {
        private int _score;

        [SetUp]
        public void SetUp()
        {
            _score = 0;
        }

        [Test]
        public void initial_score_is_zero()
        {
            AssertScoreEquals(0);
        }

        [Test]
        public void total_score_is_score_from_first_try()
        {
            AddTry(3);

            AssertScoreEquals(3);
        }

        [Test]
        public void total_score_is_aggregate_score_of_all_tries()
        {
            AddTry(4);
            AddTry(5);

            AssertScoreEquals(9);
        }

        private void AddTry(int tryScore)
        {
            _score += tryScore;
        }

        private void AssertScoreEquals(int expected)
        {
            Assert.AreEqual(expected, _score);
        }
    }
}
