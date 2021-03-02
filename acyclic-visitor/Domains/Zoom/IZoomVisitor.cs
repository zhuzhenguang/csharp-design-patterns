namespace acyclic_visitor.Domains.Zoom
{
    public interface IZoomVisitor : IModemVisitor
    {
        void Visit(Zoom zoom);
    }
}