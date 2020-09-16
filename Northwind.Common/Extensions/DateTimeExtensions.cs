using System;

namespace Northwind.Common.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToDate(this DateTime? dateTime)
        {
            if (!dateTime.HasValue) return string.Empty;

            return dateTime.Value.ToString("dd/MM/yyyy");
        }
    }
}
