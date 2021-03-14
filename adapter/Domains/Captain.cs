namespace adapter.Domains
{
    public class Captain
    {
        private readonly IRowingBoat rowingBoat;

        public Captain(IRowingBoat rowingBoat)
        {
            this.rowingBoat = rowingBoat;
        }

        public void Row()
        {
            rowingBoat.Row();
        }
    }
}