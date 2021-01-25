using System;
using Xunit;

namespace ByteDecoder.Common.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void ToInt_ReturnsInteger_WhenInputIsCorrect()
        {
            // Arrange
            var stringNumber = "123";

            // Act
            int result = stringNumber.ToInt();

            // Assert
            Assert.Equal(123, result);
        }

        [Fact]
        public void ToInt_ThrowsException_WhenInputIsIncorrect()
        {
            // Arrange
            var stringNumber = "Aba123";

            // Act
            var exception = Record.Exception(() =>
            {
                stringNumber.ToInt();
            });

            // Assert
            Assert.IsType<FormatException>(exception);
        }

        [Fact]
        public void ToDouble_ReturnsDouble_WhenInputIsCorrect()
        {
            // Arrange
            var stringNumber = "123";

            // Act
            double result = stringNumber.ToDouble();

            // Assert
            Assert.Equal(123, result);
        }

        [Fact]
        public void ToDouble_ReturnsNaN_WhenInputIsIncorrect()
        {
            // Arrange
            var stringNumber = "Aba123";

            // Act
            double result = stringNumber.ToDouble();

            // Assert
            Assert.True(double.IsNaN(result));
        }

        [Fact]
        public void ToCamelCase_ReturnsValidResults_WhenInputLenghtIsGreaterThanOne()
        {
            // Arrange
            var source = "SuperLupper";

            // Act
            var result = source.ToCamelCase();

            // Assert
            Assert.Equal("superLupper", result);
        }

        [Fact]
        public void ToCamelCase_ReturnsSameString_WhenInputLenghtIsNotGreaterThanOne()
        {
            // Arrange
            var source = "S";

            // Act
            var result = source.ToCamelCase();

            // Assert
            Assert.Equal("S", result);
        }

        [Fact]
        public void ToCamelCase_ReturnsSameInput_WhenInputLenghtIsEmpty()
        {
            // Arrange
            var source = string.Empty;

            // Act
            var result = source.ToCamelCase();

            // Assert
            Assert.Equal(string.Empty, result);
        }
    }
}
