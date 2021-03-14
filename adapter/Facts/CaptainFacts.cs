using adapter.Domains;
using Moq;
using Xunit;

namespace adapter.Facts
{
    public class CaptainFacts
    {
        [Fact]
        public void captain_should_sail_boat()
        {
            var mockLogger = new Mock<ILogger>();
            var captain = new Captain(new FishingBoatAdaptor(mockLogger.Object));

            captain.Row();

            mockLogger.Verify(logger => logger.Info("Fishing boat sails"));
        }
    }
}