namespace acyclic_visitor.Domains
{
    public interface IModem
    {
        void Accept(IModemVisitor visitor);
    }
}