namespace abstract_factory.Domains
{
    public interface IKingdomFactory
    {
        IKing CreateKing();
        ICastle CreateCastle();
        IArmy CreateArmy();
    }
}