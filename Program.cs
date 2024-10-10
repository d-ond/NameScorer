using FuzzySharp;

namespace NameScorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Levenshtein levenshtein = new Levenshtein();
            JaroWinkler jaroWinkler = new JaroWinkler();

            Console.WriteLine("Enter the first name: ");
            string name1 = Console.ReadLine() ?? "";
        
            Console.WriteLine("Enter the second name: ");
            string name2 = Console.ReadLine() ?? "";

            var jw_score = jaroWinkler.GetJaroWinklerDistance(name1, name2);
            var l_score = levenshtein.GetLevenshteinDistance(name1, name2);

            Console.WriteLine($"The similarity score between \"{name1}\" and \"{name2}\" using Jaro-Winkler is: {jw_score}");
            Console.WriteLine($"The similarity score between \"{name1}\" and \"{name2}\" using Levenshtein is: {l_score}");
        }
    }
}