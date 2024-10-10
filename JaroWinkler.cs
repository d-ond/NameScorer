using FuzzySharp;

namespace NameScorer
{
    class JaroWinkler
    {
        public int GetJaroWinklerDistance(string name1, string name2) {
            return Fuzz.PartialRatio(name1, name2);
        }
    }
}