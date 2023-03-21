using System.Text.RegularExpressions;

namespace RegularPractice.ConsoleApp.AppCode.Extension
{
    static partial class Extension
    {
        public const string EMAIL_PATTERN = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string PHONE_PATTERN = @"^(\+994|0)(50|51|55|70|77|99|0)-(\d{3}-\d{2}-\d{2})$";
        public const string NAME_PATTERN = @"^[A-ZƏ]{1}[a-zə]{2,}$";
        public const string PASSWORD_PATTERN = @"^((?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#])).{8,}$";


        public static bool IsEmail(this string value)
        {
            Match emailResult = Regex.Match(value, EMAIL_PATTERN);

            if (emailResult.Success)
                return true;

            return false;
        }

        public static bool IsPhone(this string value)
        {
            if (Regex.IsMatch(value, PHONE_PATTERN))
                return true;

            return false;
        }



        public static bool IsName(this string value)
        {
            if (Regex.IsMatch(value, NAME_PATTERN))
                return true;

            return false;
        }

        public static bool IsPassword(this string value)
        {
            if (Regex.IsMatch(value, PASSWORD_PATTERN))
                return true;

            return false;
        }
    }
}
