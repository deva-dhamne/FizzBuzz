using FluentAssertions;
using FizzBuzzLogic;

namespace FizzBuzzUnitTests
{
    public class FizzBuzzShould
    {
        [Fact]
        public void Return_SimpleNumber_Fact()
        {
            var result = FizzBuzz.Calculate(1);

            result.Should().Be("1");
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void Return_SimpleNumber(int number, string expectedSimpleNumber)
        {
            var result = FizzBuzz.Calculate(number);

            result.Should().Be(expectedSimpleNumber);
        }

        [Fact]
        public void Return_FizzNumber_Fact()
        {
            var result = FizzBuzz.Calculate(3);

            result.Should().Be("Fizz");
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        [InlineData(18, "Fizz")]
        [InlineData(21, "Fizz")]
        public void Return_FizzNumber(int number, string expectedFizzNumber)
        {
            var result = FizzBuzz.Calculate(number);

            result.Should().Be(expectedFizzNumber);
        }

        [Fact]
        public void Return_BuzzNumber_Fact()
        {
            var result = FizzBuzz.Calculate(5);

            result.Should().Be("Buzz");
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        [InlineData(25, "Buzz")]
        public void Return_BuzzNumber(int number, string expectedBuzzNumber)
        {
            var result = FizzBuzz.Calculate(number);

            result.Should().Be(expectedBuzzNumber);
        }

        [Fact]
        public void Return_FizzBuzzNumber_Fact()
        {
            var result = FizzBuzz.Calculate(15);

            result.Should().Be("FizzBuzz");
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        [InlineData(60, "FizzBuzz")]
        public void Return_FizzBuzzNumber(int number, string expectedFizzBuzzNumber)
        {
            var result = FizzBuzz.Calculate(number);

            result.Should().Be(expectedFizzBuzzNumber);
        }
    }
}