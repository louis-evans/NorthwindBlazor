using System.Linq;

namespace Northwind.Common.Extensions
{
    public static class NumberExtensions
    {
        public static string Round(this float flt, int dp = 2) => flt.ToString(GetFormat(dp));
        
        public static string Round(this double dub, int dp = 2) => dub.ToString(GetFormat(dp));
        
        public static string Round(this decimal dec, int dp = 2) => dec.ToString(GetFormat(dp));

        private static string GetFormat(int dp) => $"0.{string.Join("", Enumerable.Repeat("0", dp))}";
    }
}
