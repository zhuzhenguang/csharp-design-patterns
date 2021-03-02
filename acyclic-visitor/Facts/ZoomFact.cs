using acyclic_visitor.Domains;
using acyclic_visitor.Domains.Zoom;
using Moq;
using NLog;
using Xunit;

namespace acyclic_visitor.Facts
{
    public class ZoomFact
    {
        [Fact]
        public void zoom_should_be_visited_by_dos()
        {
            IModem zoom = new Zoom();
            var mockLogger = new Mock<ILogger>();
            IModemVisitor configureForDosVisitor = new ConfigureForDosVisitor(mockLogger.Object);

            zoom.Accept(configureForDosVisitor);

            mockLogger.Verify(logger => logger.Info("Zoom used with Dos configurator."), Times.Once);
        }

        [Fact]
        public void zoom_should_be_visited_by_unix()
        {
            IModem zoom = new Zoom();
            var mockLogger = new Mock<ILogger>();
            IModemVisitor configureForUnixVisitor = new ConfigureForUnixVisitor(mockLogger.Object);

            zoom.Accept(configureForUnixVisitor);

            mockLogger.Verify(logger => logger.Info("Zoom used with Unix configurator."), Times.Once);
        }
    }
}