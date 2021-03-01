using System;
using abstract_factory.Domains.Elven;
using abstract_factory.Domains.Orc;
using abstract_factory.Facts;

namespace abstract_factory.Domains
{
    public static class FactoryMaker
    {
        public static IKingdomFactory Create(KingdomType kingdomType)
        {
            return kingdomType switch
            {
                KingdomType.ELF => new ElfKingdomFactory(),
                KingdomType.ORC => new OrcKingdomFactory(),
                _ => throw new Exception()
            };
        }
    }
}