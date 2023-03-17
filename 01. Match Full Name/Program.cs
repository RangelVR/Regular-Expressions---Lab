using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";

MatchCollection matches = Regex.Matches(text, pattern);

foreach (Match match in matches)
{
    Console.Write(match + " ");
}