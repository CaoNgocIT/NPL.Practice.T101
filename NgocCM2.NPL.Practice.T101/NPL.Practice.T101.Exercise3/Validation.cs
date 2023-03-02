using System.Text.RegularExpressions;

namespace NPL.Practice.T101.Exercise3
{
    public static class Validation
    {
        /// <summary>
        /// Check valid phone number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static bool IsValidPhoneNumber(this string phoneNumber)
        {
            return (Regex.IsMatch(phoneNumber, "^0\\d{2}\\s\\d{3}\\s\\d{4}$"));
        }

        /// <summary>
        /// Check a valid group
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static bool IsValidGroup(this string group)
        {
            return group.ToLower().Equals("family") || group.ToLower().Equals("colleague") || group.ToLower().Equals("friend") || group.ToLower().Equals("other");
        }
    }
}
