using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleAppRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("az"); 
            //string text = "FILE://demo.text";

            //var options = RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.ECMAScript);


            //Console.WriteLine(Regex.IsMatch(text, "^file://", RegexOptions.None));
            //Console.WriteLine(Regex.IsMatch(text, "^file://", RegexOptions.IgnoreCase));
            //Console.WriteLine(Regex.IsMatch(text, "^file://", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant));


            //string text = "abc\n123";
            //Console.WriteLine(Regex.IsMatch(text, @"^\d+$"));
            //Console.WriteLine(Regex.IsMatch(text, @"^\d+$",RegexOptions.Singleline));
            //Console.WriteLine(Regex.IsMatch(text, @"^\d+$",RegexOptions.Multiline));

            //string text = @"demo
            //                salam
            //                c# course";

            //Console.WriteLine("None:");
            //Console.WriteLine(Regex.Match(text,@"^.*$").Value);
            //Console.WriteLine("Singleline:");
            //Console.WriteLine(Regex.Match(text,@"^.*$",RegexOptions.Singleline).Value);

            string text = "demo123\n2022a\n1024";

            var options = RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace;

            string pattern = @"^   # setrin bashlangicini bildirir
                               \d+ # ardicil gelen reqemleri(yeni ededi) bildirir
                               $   # setrin bitisini bildirir";

            MatchCollection matches = Regex.Matches(text, pattern, options);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}