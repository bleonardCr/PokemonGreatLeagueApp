namespace PokemonGreatLeagueApp.Models
{
    public static class PokemonEntryMap
    {
        private static readonly Dictionary<string, PokemonEntry> _entries =
            new Dictionary<string, PokemonEntry>();

        public static void Add(PokemonEntry entry)
        {
            if (!_entries.ContainsKey(entry.Name))
                _entries[entry.Name] = entry;
        }

        public static PokemonEntry? Get(string name)
        {
            return _entries.TryGetValue(name, out var entry) ? entry : null;
        }

        public static IEnumerable<PokemonEntry> All => _entries.Values;
    }
}
