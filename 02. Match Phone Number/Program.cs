using System.Text.RegularExpressions;

string phoneNumberas = Console.ReadLine();

string pattern = @"\+359(.|-)2\1\d{3}\1\d{4}\b";

MatchCollection matches = Regex.Matches(phoneNumberas, pattern);

Console.WriteLine(string.Join(", ", matches));