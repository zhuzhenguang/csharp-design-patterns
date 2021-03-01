namespace abstract_factory.Domains.Elven
{
    public class ElfKingdomFactory : IKingdomFactory
    {
        public IKing CreateKing() => new ElfKing();
        public ICastle CreateCastle() => new ElfCastle();
        public IArmy CreateArmy() => new ElfArmy();
    }

    public class ElfKing : IKing
    {
        public string Description => "This is Elven king";
    }

    public class ElfCastle : ICastle
    {
        public string Description => "This is Elven castle";
    }

    public class ElfArmy : IArmy
    {
        public string Description => "This is Elven army";
    }
}