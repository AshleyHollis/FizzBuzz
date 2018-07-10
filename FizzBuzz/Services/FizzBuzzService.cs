namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string CalculateFizzBuzzValue(int operand)
        {
            var isDivisableByThree = operand.IsDivisableBy(3);
            var isDivisableByFive = operand.IsDivisableBy(5);
            var isDivisableByThreeAndFive = isDivisableByThree & isDivisableByFive;

            if (isDivisableByThreeAndFive)
            {
                return "FizzBuzz";
            }

            if (isDivisableByThree)
            {
                return "Fizz";
            }

            if (isDivisableByFive)
            {
                return "Buzz";
            }

            return operand.ToString();
        }
    }
}

public interface IFizzBuzzService
{
    string CalculateFizzBuzzValue(int operand);
}