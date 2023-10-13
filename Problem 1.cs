//
//If we list all the natural numbers below $10$ that are multiples of $3$ or $5$, we get $3, 5, 6$ and $9$. The sum of these multiples is $23$.
//Find the sum of all the multiples of $3$ or $5$ below $1000$.
//

namespace MathProblems
{
    public class Problem1
    {
        public static int maxNumber = 1000;

        public static void Run()
        {
            int sum = 0;

            for (int i = 0; i < maxNumber; i++)
            {
                if (i % 5 == 0 || i % 3 == 0) 
                {
                    sum += i;
                }
            }
            FileMaker.CreateResponse( "solution 1" ,Convert.ToString(sum));

        }



    }
}