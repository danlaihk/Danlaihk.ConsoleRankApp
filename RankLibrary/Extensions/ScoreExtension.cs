using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankLibrary.Extensions
{
    public static class ScoreExtension
    {
        public static string ParseAsRankBySwitchRefactored(this float score)
        {

            return score switch
            {
                >= 100 or <= 0 => "invalid score",
                >= 97 => "A+",
                >= 93 => "A",
                >= 90 => "A-",
                >= 87 => "B+",
                >= 83 => "B-",
                >= 80 => "B+",
                >= 77 => "C+",
                >= 73 => "C",
                >= 70 => "C-",
                >= 67 => "D+",
                >= 63 => "D",
                >= 60 => "D-",
                < 60 => "F",
                _ => "invalid score",

            };

        }
        internal static string ParseAsRankByYourWay(this float score)
        {
            return score switch
            {
                >= 97 and <= 100 => "A+",
                >= 93 and < 97 => "A",
                >= 90 and < 93 => "A-",
                >= 87 and < 90 => "B+",
                >= 83 and < 87 => "B-",
                >= 80 and < 83 => "B+",
                >= 77 and < 80 => "C+",
                >= 73 and < 77 => "C",
                >= 70 and < 73 => "C-",
                >= 67 and < 70 => "D+",
                >= 63 and < 67 => "D",
                >= 60 and < 63 => "D-",
                < 60 => "F",
                _ => "invalid score",
            };
        }
    }

}
