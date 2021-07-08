using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using NLog;

namespace ambassador.Domains
{
    internal class ServiceAmbassador : IRemoteService
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        private const int Retries = 3;
        private const int DelayMs = 3000;

        public long DoRemoveFunction(int value)
        {
            var retries = 0;
            var result = (long) RemoteStatus.Failure;
            foreach (var index in Enumerable.Range(0, Retries))
            {
                if (retries >= Retries)
                {
                    return (long) RemoteStatus.Failure;
                }

                if ((result = CheckLatency(value)) == (long) RemoteStatus.Failure)
                {
                    Logger.Error($"Failed to reach remote: ({index})");
                    retries++;
                    Thread.Sleep(DelayMs);
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        private static long CheckLatency(int value)
        {
            var stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            long result = RemoteService.Get().DoRemoveFunction(value);
            stopwatch.Stop();

            Logger.Info($"Time taken (ms): {stopwatch.ElapsedMilliseconds}");
            return result;
        }
    }
}