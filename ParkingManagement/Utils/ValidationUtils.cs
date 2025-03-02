using System.Text.RegularExpressions;

namespace ParkingManagement.Utils
{
    public static class ValidationUtils
    {
        public static bool IsValidText(string text, bool allowNumbers = true, bool allowSpaces = true, string customPattern = null)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            if (!string.IsNullOrEmpty(customPattern) && !Regex.IsMatch(text, customPattern))
                return false;

            string pattern = allowNumbers
                ? (allowSpaces ? @"^[a-zA-Z0-9 ]+$" : @"^[a-zA-Z0-9]+$")
                : (allowSpaces ? @"^[a-zA-Z ]+$" : @"^[a-zA-Z]+$");

            if (!Regex.IsMatch(text, pattern))
                return false;

            if (text.Trim() != Regex.Replace(text, @"\s+", " "))
                return false;

            return true;
        }
    }
}
