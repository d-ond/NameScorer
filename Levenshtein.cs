public class Levenshtein
{
    // implementation of levenshtein distance
    public int GetLevenshteinDistance(string name1, string name2) //O(n*m)
    {
        var name1Length = name1.Length;
        var name2Length = name2.Length;

        var matrix = new int[name1Length + 1, name2Length + 1];

        if (name1Length == 0)
            return name2Length;

        if (name2Length == 0)
            return name1Length;

        for (var i = 0; i <= name1Length; matrix[i, 0] = i++){}
        for (var j = 0; j <= name2Length; matrix[0, j] = j++){}

        for (var i = 1; i <= name1Length; i++)
        {
            for (var j = 1; j <= name2Length; j++)
            {
                var cost = (name2[j - 1] == name1[i - 1]) ? 0 : 1;

                matrix[i, j] = Math.Min(
                    Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                    matrix[i - 1, j - 1] + cost);
            }
        }

        return matrix[name1Length, name2Length];
    }
}