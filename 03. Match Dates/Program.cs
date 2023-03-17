using System.Text.RegularExpressions;

string dates = Console.ReadLine();

string pattern = @"\b(?<date>\d{2})(\.|-|/)(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})";

MatchCollection matches = Regex.Matches(dates, pattern);

foreach(Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["date"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
}