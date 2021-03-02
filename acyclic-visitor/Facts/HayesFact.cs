using acyclic_visitor.Domains;
using acyclic_visitor.Domains.Hayes;
using Moq;
using NLog;
using Xunit;

namespace acyclic_visitor.Facts
{
    public class HayesFact
    {
        [Fact]
        public void hayes_should_be_visited_by_dos()
        {
            IModem hayes = new Hayes();
            var mockLogger = new Mock<ILogger>();
            IModemVisitor configureForDosVisitor = new ConfigureForDosVisitor(mockLogger.Object);

            hayes.Accept(configureForDosVisitor);

            mockLogger.Verify(logger => logger.Info("Hayes used with Dos configurator."), Times.Once);
        }

        [Fact]
        public void hayes_should_be_visited_by_unix()
        {
            IModem hayes = new Hayes();
            var mockLogger = new Mock<ILogger>();
            IModemVisitor configureForUnixVisitor = new ConfigureForUnixVisitor(mockLogger.Object);

            hayes.Accept(configureForUnixVisitor);

            mockLogger.Verify(logger => logger.Info(It.IsAny<string>()), Times.Never);
        }
    }
}