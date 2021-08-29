using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class ScoreUtility
    {
        public static IScored BestofTwo(IScored Assigment1, IScored Assignment2)
        {
            var score1 = Assigment1.score / Assigment1.MaximumScore;
            var score2 = Assignment2.score / Assignment2.MaximumScore;

            if(score1 > score2)
            {
                return Assigment1;
            }
            else
            {
                return Assignment2;
            }
        }
    }
}
