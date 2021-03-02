namespace acyclic_visitor.Domains.Hayes
{
    public class Hayes : IModem
    {
        public void Accept(IModemVisitor visitor)
        {
            if (visitor is IHayesVisitor hayesVisitor)
            {
                hayesVisitor.Visit(this);
            }
        }

        public override string ToString() => "Hayes";
    }
}