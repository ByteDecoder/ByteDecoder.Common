using System;
using Xunit;

namespace ByteDecoder.Common.Tests
{
    public class EnumExtensionsTests
    {
        private enum Testify
        {
            Aba,
            Opal,
            Nepal,
        }

        [Fact]
        public void ToEnum_ReturnsAValidEnumType_WhenValueIsProvided()
        {
            // Arrange
            var value = "Aba";

            // Act
            var result = value.ToEnum<Testify>();

            // Assert
            Assert.Equal(Testify.Aba, result);
            Assert.IsType<Testify>(result);
        }

        [Fact]
        public void ToEnum_ThrowsAnException_WhenValueIsInvalid()
        {
            // Arrange
            var value = "Abal";

            // Act
            var exception = Record.Exception(() =>
            {
                value.ToEnum<Testify>();
            });

            // Assert
            Assert.IsType<ArgumentException>(exception);
        }

        [Fact]
        public void ToEnum_WithDefaultValue_ReturnsValidValue_WhenCurrentValueIsValid()
        {
            // Arrange
            var value = "Aba";

            // Act
            var result = value.ToEnum(Testify.Nepal);

            // Assert
            Assert.Equal(Testify.Aba, result);
            Assert.IsType<Testify>(result);
        }

        [Fact]
        public void ToEnum_WithDefaultValue_ReturnsDefaultValue_WhenCurrentValueIsInvalid()
        {
            // Arrange
            var value = "Abal";

            // Act
            var result = value.ToEnum(Testify.Opal);

            // Assert
            Assert.Equal(Testify.Opal, result);
            Assert.IsType<Testify>(result);
        }

        [Fact]
        public void ToEnum_WithDefaultValue_ReturnsDefaultValue_WhenCurrentValueIsEmpty()
        {
            // Arrange
            var value = string.Empty;

            // Act
            var result = value.ToEnum(Testify.Opal);

            // Assert
            Assert.Equal(Testify.Opal, result);
            Assert.IsType<Testify>(result);
        }
    }
}
