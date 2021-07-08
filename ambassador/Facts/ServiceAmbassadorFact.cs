using ambassador.Domains;
using Xunit;

namespace ambassador.Facts
{
    public class ServiceAmbassadorFact
    {
        [Fact]
        private void test()
        {
            long result = new ServiceAmbassador().DoRemoveFunction(10);
            
            Assert.True(result is 100 or (long) RemoteStatus.Failure);
        }
    }
}