using acyclic_visitor.Domains.Zoom;
using NLog;

namespace acyclic_visitor.Domains
{
    public class ConfigureForUnixVisitor : IZoomVisitor 
    {
        private readonly ILogger logger;

        public ConfigureForUnixVisitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Visit(Zoom.Zoom modem)
        {
            logger.Info($"{modem} used with Unix configurator.");
        }
    }
}