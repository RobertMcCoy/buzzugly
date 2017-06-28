using System.Collections.Generic;

namespace sustainable
{
    class FizzBuzzPlayer
    {
        public string Play(int input)
        {
            if (IsDivisibleByValue(input, 3) && IsDivisibleByValue(input, 5))
            {
                return "FizzBuzz";
            }

            if (IsDivisibleByValue(input, 3)) return "Fizz";
            if (IsDivisibleByValue(input, 5)) return "Buzz";
            return input.ToString();
        }

        private bool IsDivisibleByValue(int testValue, int divisor)
        {
            return (testValue % divisor == 0);
        }
    }
}