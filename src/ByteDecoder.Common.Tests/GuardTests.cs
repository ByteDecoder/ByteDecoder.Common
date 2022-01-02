using System;
using System.Collections.Generic;
using ByteDecoder.Common.GuardClauses;
using Xunit;

namespace ByteDecoder.Common.Tests
{
    public class GuardTests
    {
        private readonly IEnumerable<string> _drawingMaterials;

        public GuardTests()
        {
            _drawingMaterials = new List<string> { "Pastel", "charcoal" };
        }

        [Fact]
        public void ThrowIfArgumentIsNull_ThrowsNullArgumentException_WhenSourceIsNull()
        {
            // Arrange
            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNull<IEnumerable<string>?>(null, "collection");
            });

            // Assert
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        public void ThrowIfArgumentIsNull_DoNotThrowsNullArgumentException_WhenSourceIsNotNull()
        {
            // Arrange
            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNull(_drawingMaterials, nameof(_drawingMaterials));
            });

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ThrowIfArgumentIsNullWithMessage_ThrowsNullArgumentException_WhenSourceIsNull()
        {
            // Arrange
            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNull((IEnumerable<string>?)null, "collection", "An error occurred");
            });

            // Assert
            Assert.IsType<ArgumentNullException>(exception);
            Assert.Contains("An error occurred", exception.Message, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public void ThrowIfArgumentIsNullWithMessage_DoNotThrowsNullArgumentException_WhenSourceIsNotNull()
        {
            // Arrange
            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNull(_drawingMaterials, nameof(_drawingMaterials), "An error occurred");
            });

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ThrowIfArgumentIsNullOrEmpty_ThrowsNullArgumentException_WhenSourceIsNull()
        {
            // Arrange
            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNullOrEmpty(null, "word");
            });

            // Assert
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        public void ThrowIfArgumentIsNullOrEmpty_ThrowsNullArgumentException_WhenSourceIsEmpty()
        {
            // Arrange
            var word = string.Empty;

            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNullOrEmpty(word, nameof(word));
            });

            // Assert
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        public void ThrowIfArgumentIsNullOrEmpty_DoNotThrowsNullArgumentException_WhenSourceHasValidValue()
        {
            // Arrange
            var word = "Pastel colors";

            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNullOrEmpty(word, nameof(word));
            });

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ThrowIfArgumentIsNullOrEmptyWithMessage_ThrowsNullArgumentException_WhenSourceIsNull()
        {
            // Arrange
            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNullOrEmpty(null, "word", "An error occurred");
            });

            // Assert
            Assert.IsType<ArgumentNullException>(exception);
            Assert.Contains("An error occurred", exception.Message, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public void ThrowIfArgumentIsNullOrEmptyWithMessage_ThrowsNullArgumentException_WhenSourceIsEmpty()
        {
            // Arrange
            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNullOrEmpty(string.Empty, "word", "An error occurred");
            });

            // Assert
            Assert.IsType<ArgumentNullException>(exception);
            Assert.Contains("An error occurred", exception.Message, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public void ThrowIfArgumentIsNullOrEmptyWithMessage_DoNotThrowsNullArgumentException_WhenSourceIsValid()
        {
            // Arrange
            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentIsNullOrEmpty("word", "word", "An error occurred");
            });

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ThrowIfArgumentOutOfRange_ThrowsArgumentOutOfRangeException_WhenPredicateIsTrue()
        {
            // Arrange
            static bool Predicate() => 2 > 0;

            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentOutOfRange(Predicate, nameof(Predicate), "Predicate is true");
            });

            // Assert
            Assert.IsType<ArgumentOutOfRangeException>(exception);
            Assert.NotNull(exception.Message);
        }

        [Fact]
        public void ThrowIfArgumentOutOfRange_DoNotThrowsArgumentOutOfRangeException_WhenPredicateIsFalse()
        {
            // Arrange
            static bool Predicate() => -2 > 0;

            // Act
            var exception = Record.Exception(() =>
            {
                Guard.Break.IfArgumentOutOfRange(Predicate, nameof(Predicate), "Predicate is true");
            });

            // Assert
            Assert.Null(exception);
        }
    }
}
