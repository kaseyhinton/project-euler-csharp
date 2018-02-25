using System.Linq;

namespace project_euler.problems
{
    public static class Problem4
    {
        /*
        Problem 4
        Largest Palindrome Product

        A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        Find the largest palindrome made from the product of two 3-digit numbers.
            
        Answer: 906609
         */

        public static void Solve()
        {
            int first = 0;
            int second = 0;
            int max = 0;
            bool found = false;

            while (!found)
            {
                for(var i = 999; i > 1; i--)
                {
                    for(var j = 999; j > 1; j--)
                    {
                        int val = i * j;

                        if (CheckPalindrome(val))
                        {
                            if (val > max)
                            {
                                first = i;
                                second = j;
                                max = val;
                                found = true;
                            }
                        }
                    }
                }
            }
            System.Console.WriteLine($"Problem 4: {max} by {first} x {second}");
        }

        private static bool CheckPalindrome(int value)
        {
            string reversed = Reverse(value.ToString());

            return value.ToString() == reversed;
        }

        private static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}