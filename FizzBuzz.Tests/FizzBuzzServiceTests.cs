using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzServiceTests
    {
        private static readonly IFizzBuzzService FizzBuzzService = new FizzBuzzService();

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void CalculateFizzBuzzValue_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3(int value)
        {
            FizzBuzzService.CalculateFizzBuzzValue(value).Should().Be("Fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void CalculateFizzBuzzValue_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5(int value)
        {
            FizzBuzzService.CalculateFizzBuzzValue(value).Should().Be("Buzz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void CalculateFizzBuzzValue_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5(int value)
        {
            FizzBuzzService.CalculateFizzBuzzValue(value).Should().Be("FizzBuzz");
        }

        [Theory]
        [InlineData(7)]
        [InlineData(17)]
        [InlineData(1)]
        public void CalculateFizzBuzzValue_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5(int value)
        {
            FizzBuzzService.CalculateFizzBuzzValue(value).Should().Be($"{value}");
        }
    }
}