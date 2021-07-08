using System;
using System.Threading;
using ambassador.Facts;

namespace ambassador.Domains
{
    internal class RemoteService : IRemoteService
    {
        private const int ThreshHold = 200;
        private readonly IRandomProvider randomProvider;
        private static readonly IRemoteService Instance = new RemoteService();

        public static IRemoteService Get() => Instance;

        private RemoteService() : this(new RandomProvider())
        {
        }

        public RemoteService(IRandomProvider randomProvider) => this.randomProvider = randomProvider;

        public long DoRemoveFunction(int value)
        {
            var waitTime = (int) Math.Floor(randomProvider.Random() * 1000);
            Thread.Sleep(waitTime);
            return waitTime <= ThreshHold ? value * 10 : (long) RemoteStatus.Failure;
        }
    }

    internal class RandomProvider : IRandomProvider
    {
        public double Random() => new Random().NextDouble();
    }
}