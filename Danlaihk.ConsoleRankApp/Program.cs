using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Danlaihk.ConsoleRankApp.Extensions;
using static System.Formats.Asn1.AsnWriter;

namespace Danlaihk.ConsoleRankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //benchmark 
            //RunBenchMark();

            //get rank
            RunAsConsoleWrite();


        }

        private static void RunBenchMark() => BenchmarkRunner.Run<IfVsSwitch>();
        private static void RunAsConsoleWrite() {

            Dictionary<string, float> scoreDict = new Dictionary<string, float>()
            {
                { "Sophia", 92.2f },
                { "Andrew", 89.6f },
                { "Emma", 85.6f },
                { "Logan", 91.2f },
            };

            Console.WriteLine("original condition ");

            foreach (var studentScore in scoreDict)
            {
                Console.WriteLine($" {studentScore.Key} get {studentScore.Value.ParseAsRankByOriginalWay()} with score {studentScore.Value}. ");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("refactored condition");

            foreach (var studentScore in scoreDict)
            {
                Console.WriteLine($" {studentScore.Key} get {studentScore.Value.ParseAsRankBySwitchRefactored()} with score {studentScore.Value}. ");
            }
        }

    }

    /// <summary>
    /// 測試用擂台
    /// </summary>
    public class IfVsSwitch
    {
        [Benchmark]
        public void GetByOriginalWay()
        {
            IEnumerable<int> scoreEnum = Enumerable.Range(0, 100);
            foreach (var score in scoreEnum)
            {

                var rankOfOriginWay = ((float)score).ParseAsRankByOriginalWay() ?? "";

            }
        }

        [Benchmark]
        public void GetByRefactorIfWay()
        {
            IEnumerable<int> scoreEnum = Enumerable.Range(0, 100);
            foreach (var score in scoreEnum)
            {

                var rankOfOriginWay = ((float)score).ParseAsRankByIf() ?? "";

            }
        }
    }
}
