using NLog;

namespace acyclic_visitor.Domains
{
    public class ConfigureForDosVisitor : IAllModemVisitor
    {
        private readonly ILogger logger;

        public ConfigureForDosVisitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Visit(Zoom.Zoom zoom)
        {
            logger.Info($"{zoom} used with Dos configurator.");
        }

        public void Visit(Hayes.Hayes hayes)
        {
            logger.Info($"{hayes} used with Dos configurator.");
        }
    }
}