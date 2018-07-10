namespace FizzBuzz
{
    public static class NumberExtenstions
    {
        public static bool IsDivisableBy(this int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }
    }
}
