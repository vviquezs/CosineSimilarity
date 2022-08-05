// See https://aka.ms/new-console-template for more information

using CosineSimilarity;

var result = Result.cosine_similarity(new List<int>() {2, 4, 5, 8}, new List<double>() {7, 5, 12, 1}, new List<int>() {1, 4, 7, 8},
    new List<double>() {8, 6, 13, 2});
Console.WriteLine($"Cosine similarity is: {result}");