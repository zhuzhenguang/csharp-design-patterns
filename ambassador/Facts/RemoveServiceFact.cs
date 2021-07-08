using ambassador.Domains;
using Xunit;

namespace ambassador.Facts
{
    public class RemoveServiceFact
    {
        [Fact]
        private void should_failed()
        {
            var removeService = new RemoteService(new StaticRandomProvider(0.21));

            long result = removeService.DoRemoveFunction(10);

            Assert.Equal((long) RemoteStatus.Failure, result);
        }

        [Fact]
        private void should_success()
        {
            var removeService = new RemoteService(new StaticRandomProvider(0.2));
            
            long result = removeService.DoRemoveFunction(10);
            
            Assert.Equal(100, result);
        }
    }

    internal class StaticRandomProvider : IRandomProvider
    {
        private readonly double value;

        public StaticRandomProvider(double value)
        {
            this.value = value;
        }

        public double Random()
        {
            return value;
        }
    }
}