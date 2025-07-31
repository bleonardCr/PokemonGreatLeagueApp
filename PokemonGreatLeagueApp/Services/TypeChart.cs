using System;
using System.Collections.Generic;

namespace NebsojiPVPTrainer.Services
{
    public static class TypeChart
    {
        private static readonly Dictionary<string, Dictionary<string, double>> Chart
            = new Dictionary<string, Dictionary<string, double>>(StringComparer.OrdinalIgnoreCase)
            {
                ["normal"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["rock"] = 0.5, ["ghost"] = 0.0, ["steel"] = 0.5 },
                ["fire"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fire"] = 0.5, ["water"] = 0.5, ["grass"] = 2.0, ["ice"] = 2.0, ["bug"] = 2.0, ["rock"] = 0.5, ["dragon"] = 0.5, ["steel"] = 2.0 },
                ["water"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fire"] = 2.0, ["water"] = 0.5, ["grass"] = 0.5, ["ground"] = 2.0, ["rock"] = 2.0, ["dragon"] = 0.5 },
                ["electric"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["water"] = 2.0, ["electric"] = 0.5, ["grass"] = 0.5, ["ground"] = 0.0, ["flying"] = 2.0, ["dragon"] = 0.5 },
                ["grass"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fire"] = 0.5, ["water"] = 2.0, ["grass"] = 0.5, ["poison"] = 0.5, ["ground"] = 2.0, ["flying"] = 0.5, ["bug"] = 0.5, ["rock"] = 2.0, ["dragon"] = 0.5, ["steel"] = 0.5 },
                ["ice"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fire"] = 0.5, ["water"] = 0.5, ["grass"] = 2.0, ["ice"] = 0.5, ["ground"] = 2.0, ["flying"] = 2.0, ["dragon"] = 2.0, ["steel"] = 0.5 },
                ["fighting"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["normal"] = 2.0, ["ice"] = 2.0, ["rock"] = 2.0, ["dark"] = 2.0, ["steel"] = 2.0, ["poison"] = 0.5, ["flying"] = 0.5, ["psychic"] = 0.5, ["bug"] = 0.5, ["ghost"] = 0.0, ["fairy"] = 0.5 },
                ["poison"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["grass"] = 2.0, ["fairy"] = 2.0, ["poison"] = 0.5, ["ground"] = 0.5, ["rock"] = 0.5, ["ghost"] = 0.5, ["steel"] = 0.0 },
                ["ground"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fire"] = 2.0, ["electric"] = 2.0, ["grass"] = 0.5, ["poison"] = 2.0, ["flying"] = 0.0, ["bug"] = 0.5, ["rock"] = 2.0, ["steel"] = 2.0 },
                ["flying"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["electric"] = 0.5, ["grass"] = 2.0, ["fighting"] = 2.0, ["bug"] = 2.0, ["rock"] = 0.5, ["steel"] = 0.5 },
                ["psychic"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fighting"] = 2.0, ["poison"] = 2.0, ["psychic"] = 0.5, ["dark"] = 0.0, ["steel"] = 0.5 },
                ["bug"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fire"] = 0.5, ["grass"] = 2.0, ["fighting"] = 0.5, ["poison"] = 0.5, ["flying"] = 0.5, ["psychic"] = 2.0, ["ghost"] = 0.5, ["dark"] = 2.0, ["steel"] = 0.5, ["fairy"] = 0.5 },
                ["rock"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fire"] = 2.0, ["ice"] = 2.0, ["fighting"] = 0.5, ["ground"] = 0.5, ["flying"] = 2.0, ["bug"] = 2.0, ["steel"] = 0.5 },
                ["ghost"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["normal"] = 0.0, ["psychic"] = 2.0, ["ghost"] = 2.0, ["dark"] = 0.5 },
                ["dragon"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["dragon"] = 2.0, ["steel"] = 0.5, ["fairy"] = 0.0 },
                ["dark"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fighting"] = 0.5, ["psychic"] = 2.0, ["ghost"] = 2.0, ["dark"] = 0.5, ["fairy"] = 0.5 },
                ["steel"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fire"] = 0.5, ["water"] = 0.5, ["electric"] = 0.5, ["ice"] = 2.0, ["rock"] = 2.0, ["fairy"] = 2.0, ["steel"] = 0.5 },
                ["fairy"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase) { ["fighting"] = 2.0, ["dragon"] = 2.0, ["dark"] = 2.0, ["fire"] = 0.5, ["poison"] = 0.5, ["steel"] = 0.5 },
            };

        public static double GetMultiplier(IEnumerable<string> attackerTypes, IEnumerable<string> defenderTypes)
        {
            double m = 1.0;
            foreach (var atk in attackerTypes)
                if (Chart.TryGetValue(atk, out var defMap))
                    foreach (var def in defenderTypes)
                        m *= defMap.TryGetValue(def, out var e) ? e : 1.0;
            return m;
        }
    }
}
