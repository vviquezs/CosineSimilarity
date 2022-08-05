namespace CosineSimilarity
{
    internal class Result
    {
        /*
     * Complete the 'cosine_similarity' function below.
     *
     * The function is expected to return a DOUBLE.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a_keys
     *  2. DOUBLE_ARRAY a_values
     *  3. INTEGER_ARRAY b_keys
     *  4. DOUBLE_ARRAY b_values
     */

        public static double cosine_similarity(List<int> a_keys, List<double> a_values, List<int> b_keys, List<double> b_values)
        {
            if (!a_keys.Any() && !b_keys.Any())
            {
                throw new ArgumentNullException($"{nameof(a_keys)} and {nameof(b_keys)} are null");
            }

            // formula: A*B / (mag(A)*mag(B))
            // mag(A) = ||A|| = SquareRoot((x1 ^ 2) + (x2 ^ 2) + ... + (xn ^ 2))
            // first lets use linq to get the intersection of the keys between the 2 lists
            var matchingKeys = a_keys.Intersect(b_keys).ToList();
            var dotProductResult = 0.0;
            foreach (var matchingKey in matchingKeys)
            {
                var index = a_keys.IndexOf(matchingKey);
                dotProductResult += a_values[index] * b_values[index];
            }
            var magnitudeOfA = Math.Sqrt(a_values.Sum(x => Math.Pow(x, 2)));
            var magnitudeOfB = Math.Sqrt(b_values.Sum(x => Math.Pow(x, 2)));

            var result = dotProductResult / (magnitudeOfA * magnitudeOfB);
            return result;
        }
    }
}
