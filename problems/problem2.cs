namespace project_euler.problems
{
    public static class Problem2
    {
        /*
        Problem 2
        Even Fibonacci numbers

        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            
        Answer: 4613732
         */

        
        public static void Solve()
        {
            const int MAX = 4000000;
            int accumulator = 2;
            int current = 2;
            int previous = 1;

            while (accumulator <= MAX) {
                var fibbonacci = current + previous;
                if (fibbonacci % 2 == 0)
                    accumulator += fibbonacci;
                
                previous = current;
                current = fibbonacci;
            }

            System.Console.WriteLine($"Problem 2: {accumulator}");
        }
    }
}