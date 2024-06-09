using Extension = Danlaihk.ConsoleRankApp.Extensions.ScoreExtension;
using Xunit.Abstractions;
using Danlaihk.ConsoleRankApp.Extensions;

namespace TestGetRanks
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

       
        [Fact]
        public void TestSwitch()
        {
            IEnumerable<int> scoreEnum = Enumerable.Range(0, 100);
            foreach (var score in scoreEnum) {

                //output.WriteLine($"score: {score.ToString()}");

                float floatScore = (float)score;


                var rankOfOriginWay = floatScore.ParseAsRankByOriginalWay();
                var rankOfSwitchRefactored = floatScore.ParseAsRankBySwitchRefactored() ?? "";
                

                Assert.True(rankOfSwitchRefactored.GetType() == typeof(string));
                Assert.Equal(rankOfSwitchRefactored, rankOfOriginWay);
            }
        }
        [Fact]
        public void TestIf()
        {
            IEnumerable<int> scoreEnum = Enumerable.Range(0, 100);
            foreach (var score in scoreEnum)
            {

                //output.WriteLine($"score: {score.ToString()}");

                float floatScore = (float)score;


                var rankOfOriginWay = floatScore.ParseAsRankByOriginalWay();
                var rankOfSwitchRefactored = floatScore.ParseAsRankByIf() ?? "";


                Assert.True(rankOfSwitchRefactored.GetType() == typeof(string));
                Assert.Equal(rankOfSwitchRefactored, rankOfOriginWay);
            }
        }
    }


}