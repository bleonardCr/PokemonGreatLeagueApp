using System.Collections.Generic;

namespace NebsojiPVPTrainer.Services
{
    public static class TypeChart
    {
        private static readonly Dictionary<string, Dictionary<string, double>> Chart
            = new()
            {
                ["fire"] = new() { ["grass"] = 1.6, ["water"] = 0.625 },
                ["water"] = new() { ["fire"] = 1.6, ["grass"] = 0.625 },
                ["grass"] = new() { ["water"] = 1.6, ["fire"] = 0.625 },
                // … fill out the rest …
            };

        public static double GetMultiplier(string atk, string def)
        {
            if (string.IsNullOrEmpty(atk) || string.IsNullOrEmpty(def))
                return 1.0;
            if (Chart.TryGetValue(atk.ToLower(), out var row)
             && row.TryGetValue(def.ToLower(), out var mul))
                return mul;
            return 1.0;
        }
    }
}
