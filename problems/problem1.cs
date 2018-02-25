namespace project_euler.problems
{
    public static class Problem1
    {
        /*
        Problem 1
        Multiples of 3 and 5

        If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        Find the sum of all the multiples of 3 or 5 below 1000.
            
        Answer: 233168
         */

        public static void Solve()
        {
            const int MAX = 1000;
            int accumulator = 0;

            for (int i = 0; i < MAX; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    accumulator += i;
                }
            }

            System.Console.WriteLine($"Problem 1: {accumulator}");
        }
    }
}