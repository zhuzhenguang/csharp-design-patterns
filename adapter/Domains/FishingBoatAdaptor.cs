using adapter.Facts;

namespace adapter.Domains
{
    public class FishingBoatAdaptor : IRowingBoat
    {
        private readonly FishingBoat fishingBoat;

        public FishingBoatAdaptor(ILogger logger)
        {
            fishingBoat = new FishingBoat(logger);
        }

        public void Row()
        {
            fishingBoat.Sail();
        }
    }
}