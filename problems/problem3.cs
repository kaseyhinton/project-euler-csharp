namespace project_euler.problems
{
    public static class Problem3
    {
        /*
        Problem 3
        Largest Prime Factor

        The prime factors of 13195 are 5, 7, 13 and 29.
        What is the largest prime factor of the number 600851475143?
            
        Answer: 6857
         */

        public static void Solve()
        {
            const long NUM = 600851475143;
            int largestPrimeFactor = 0;

            for (int i = 2; i < 10000; i++)
            {
                if (NUM % i == 0)
                {
                    if (i > largestPrimeFactor || largestPrimeFactor == 0)
                    {
                        if (IsPrime(i))
                        {
                            largestPrimeFactor = i;
                        }
                    }
                }
            }
            System.Console.WriteLine($"Problem 3: {largestPrimeFactor}");
        }


        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= System.Math.Ceiling(System.Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}