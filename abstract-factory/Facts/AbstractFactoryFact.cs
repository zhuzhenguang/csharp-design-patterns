using abstract_factory.Domains;
using Xunit;

namespace abstract_factory.Facts
{
    public class AbstractFactoryFact
    {
        [Fact]
        public void should_create_elven_king()
        {
            IKingdomFactory kingdomFactory = FactoryMaker.Create(KingdomType.ELF);

            IKing king = kingdomFactory.CreateKing();

            Assert.Equal("This is Elven king", king.Description);
        }

        [Fact]
        public void should_create_orc_king()
        {
            IKingdomFactory kingdomFactory = FactoryMaker.Create(KingdomType.ORC);

            IKing king = kingdomFactory.CreateKing();

            Assert.Equal("This is Orc king", king.Description);
        }

        [Fact]
        public void should_create_elven_castle()
        {
            IKingdomFactory kingdomFactory = FactoryMaker.Create(KingdomType.ELF);

            ICastle castle = kingdomFactory.CreateCastle();

            Assert.Equal("This is Elven castle", castle.Description);
        }

        [Fact]
        public void should_create_orc_castle()
        {
            IKingdomFactory kingdomFactory = FactoryMaker.Create(KingdomType.ORC);

            ICastle castle = kingdomFactory.CreateCastle();

            Assert.Equal("This is Orc castle", castle.Description);
        }

        [Fact]
        public void should_create_elven_army()
        {
            IKingdomFactory kingdomFactory = FactoryMaker.Create(KingdomType.ELF);

            IArmy army = kingdomFactory.CreateArmy();

            Assert.Equal("This is Elven army", army.Description);
        }

        [Fact]
        public void should_create_orc_army()
        {
            IKingdomFactory kingdomFactory = FactoryMaker.Create(KingdomType.ORC);

            IArmy army = kingdomFactory.CreateArmy();

            Assert.Equal("This is Orc army", army.Description);
        }
    }
}