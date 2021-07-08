namespace ambassador.Domains
{
    public class Client
    {
        private readonly IRemoteService remoteService = new ServiceAmbassador();

        public long UserService(int value)
        {
            return remoteService.DoRemoveFunction(value);
        }
    }
}