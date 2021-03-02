namespace acyclic_visitor.Domains.Zoom
{
    public class Zoom : IModem
    {
        public void Accept(IModemVisitor visitor)
        {
            if (visitor is IZoomVisitor zoomVisitor)
            {
                zoomVisitor.Visit(this);
            }
        }

        public override string ToString() => "Zoom";
    }
}