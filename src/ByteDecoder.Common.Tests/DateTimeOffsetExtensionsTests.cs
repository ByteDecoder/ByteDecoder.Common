using System;
using Xunit;

namespace ByteDecoder.Common.Tests
{
    public class DateTimeOffsetExtensionsTests
    {
        [Fact]
        public void ExtendContract_ReturnsAnExtendedDateTime_WhenMonthIsProvided()
        {
            // Arrange
            var contractDate = new DateTimeOffset(2020, 2, 29, 0, 0, 0, TimeSpan.Zero);
            var expecedContractDate = new DateTimeOffset(2020, 3, 31, 23, 59, 59, 0, TimeSpan.Zero);

            // Act
            var newContractDate = contractDate.ExtendContract(1);

            // Assert
            Assert.Equal(expecedContractDate, newContractDate);
        }
    }
}
