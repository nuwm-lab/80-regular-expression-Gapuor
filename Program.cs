using System;
using System.Text.RegularExpressions;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Here are some amounts: $123.45, 2567.89, $50.00, 123.456, $1,234.56";
            
            // Pattern to match both $xxx.xx and xxx.xx formats
            string pattern = @"(?:\$)?(?:\d+,)*\d+\.\d{2}";
            
            // Create regex object
            Regex regex = new Regex(pattern);

            // Find all matches
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("Found monetary amounts:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
