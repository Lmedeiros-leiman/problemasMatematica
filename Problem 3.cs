/*
<p>The sum of the squares of the first ten natural numbers is,</p>
$$1^2 + 2^2 + ... + 10^2 = 385.$$
<p>The square of the sum of the first ten natural numbers is,</p>
$$(1 + 2 + ... + 10)^2 = 55^2 = 3025.$$
<p>Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is $3025 - 385 = 2640$.</p>
<p>Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.</p>
*/



namespace MathProblems
{
    public class Problem3
    {
        // cannot exceed four million in value
        public static int maxNumber = 100;

        public static void Run() 
        {
            double sum = 0;
            double sumsquares = 0;
            double difference = 0;

            for (int i = 1; i <= maxNumber; i++) 
            {
                sumsquares += Math.Pow(i,2);
                sum += i;
            }
            sum = Math.Pow(sum,2);

            difference = sum - sumsquares;



            FileMaker.CreateResponse("Solution 3", Convert.ToString(difference));

        }
        
    

    }
}