using acyclic_visitor.Domains.Hayes;
using acyclic_visitor.Domains.Zoom;
using acyclic_visitor.Facts;

namespace acyclic_visitor.Domains
{
    public interface IAllModemVisitor : IZoomVisitor, IHayesVisitor
    {
    }
}