using System;

namespace ByteDecoder.Common
{
    /// <summary>
    /// DateTimeOffset extensions.
    /// </summary>
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// Extend a contract based in a number of months to the last day of the month.
        /// </summary>
        /// <param name="current">Current date to extend.</param>
        /// <param name="months">Month number extension.</param>
        /// <returns>New extended DateTimeOffset.</returns>
        public static DateTimeOffset ExtendContract(this DateTimeOffset current, int months)
        {
            var newContractDate = current.AddMonths(months).AddTicks(-1);

            return new DateTimeOffset(
                newContractDate.Year,
                newContractDate.Month,
                DateTime.DaysInMonth(newContractDate.Year, newContractDate.Month),
                23, 59, 59, current.Offset);
        }
    }
}
