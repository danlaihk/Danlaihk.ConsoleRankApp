using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danlaihk.ConsoleRankApp.Extensions
{
    public static class ScoreExtension
    {
        public static string ParseAsRankByIf(this float score)
        {



            if (score > 100 || score < 0) return "invalid score";
            if (score >= 97) return "A+";
            if (score >= 93) return "A";
            if (score >= 90) return "A-";
            if (score >= 87) return "B+";
            if (score >= 83) return "B-";
            if (score >= 80) return "B+";
            if (score >= 77) return "C+";
            if (score >= 73) return "C";
            if (score >= 70) return "C-";
            if (score >= 67) return "D+";
            if (score >= 63) return "D";
            if (score >= 60) return "D-";
            if (score < 60) return "F";
            return "invalid score";


        }

        public static string ParseAsRankBySwitchRefactored(this float score)
        {

            return score switch
            {
                > 100 or < 0 => "invalid score",
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
        public static string ParseAsRankByOriginalWay(this float score)
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
