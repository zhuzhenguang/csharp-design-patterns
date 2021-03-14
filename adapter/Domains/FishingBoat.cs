using adapter.Facts;

namespace adapter.Domains
{
    internal class FishingBoat
    {
        private readonly ILogger logger;

        public FishingBoat(ILogger logger)
        {
            this.logger = logger;
        }

        public void Sail()
        {
            logger.Info("Fishing boat sails");
        }
    }
}