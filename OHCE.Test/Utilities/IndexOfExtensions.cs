namespace OHCE.Test.Utilities
{
    internal static class IndexOfExtensions
    {
        public static int IndexOfEnd(this string target, string value)
        {
            var indexOf = target.IndexOf(value, StringComparison.Ordinal);
            return indexOf + value.Length;
        }

        public static string TruncateUntil(this string toTruncate, string value)
        {
            var indexOfEnd = toTruncate.IndexOfEnd(value);
            return toTruncate[indexOfEnd..];
        }
    }
}
