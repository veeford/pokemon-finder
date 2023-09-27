
using System.Text.Json.Serialization;

namespace pokemon
{
    public class RootClass
    {
        public int Count { get; }
        public string? Next { get; }
        public string? Previous { get; }
        public List<Pokemon> Results { get; }

        public RootClass(int count, string next, string previous, List<Pokemon> results)
        {
            Count = count;
            Next = next;
            Previous = previous;
            Results = results;
        }

        public override string ToString()
        {
            return $"Count: {Count}, next: {Next}, prev: {Previous}, results: {Results.Count}";
        }
    }

    public class Pokemon
    {
        public string Name { get; }
        public string Url { get; }

        public Pokemon(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
