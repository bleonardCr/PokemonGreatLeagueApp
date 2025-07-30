using CsvHelper.Configuration;

namespace LeagueJsonGenerator.Models
{
    public class PokemonEntryMap : ClassMap<PokemonEntry>
    {
        public PokemonEntryMap()
        {
            Map(m => m.Name).Name("name");
            Map(m => m.FastMove).Name("fastMove");
            Map(m => m.ChargeMove1).Name("chargeMove1");
            Map(m => m.ChargeMove2).Name("chargeMove2");
            Map(m => m.CP).Name("cp");
            Map(m => m.League).Name("league");
        }
    }
}
