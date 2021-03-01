namespace abstract_factory.Domains.Orc
{
    public class OrcKingdomFactory : IKingdomFactory
    {
        public IKing CreateKing() => new OrcKing();
        public ICastle CreateCastle() => new OrcCastle();
        public IArmy CreateArmy() => new OrcArmy();
    }

    public class OrcArmy : IArmy
    {
        public string Description => "This is Orc army";
    }

    public class OrcCastle : ICastle
    {
        public string Description => "This is Orc castle";
    }

    public class OrcKing : IKing
    {
        public string Description => "This is Orc king";
    }
}