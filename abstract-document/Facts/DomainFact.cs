using System;
using System.Collections.Generic;
using System.Linq;
using abstract_document.Domains;
using Xunit;

namespace abstract_document.Facts
{
    public class DomainTest
    {
        private const string TestPartType = "test-part-type";
        private const string TestPartModel = "test-part-model";
        private const long TestPartPrice = 0L;

        private const string TestCarModel = "test-car-model";
        private const long TestCarPrice = 1L;

        [Fact]
        public void should_construct_part()
        {
            var partProperties = new Dictionary<string, object>
            {
                {Property.Type.ToString(), TestPartType},
                {Property.Model.ToString(), TestPartModel},
                {Property.Price.ToString(), TestPartPrice}
            };

            var part = new Part(partProperties);

            Assert.Equal(TestPartType, part.Type());
            Assert.Equal(TestPartModel, part.Model());
            Assert.Equal(TestPartPrice, part.Price());
        }

        [Fact]
        public void should_construct_car()
        {
            var partProperties = new Dictionary<string, object>
            {
                {Property.Model.ToString(), TestCarModel},
                {Property.Price.ToString(), TestCarPrice},
                {
                    Property.Parts.ToString(), new List<IDictionary<string, object>>
                    {
                        new Dictionary<string, object> {[Property.Type.ToString()] = TestPartType},
                        new Dictionary<string, object> {[Property.Model.ToString()] = TestPartModel}
                    }
                }
            };

            var car = new Car(partProperties);

            AssertAs<IHasModel>(car, c => Assert.Equal(TestCarModel, c.Model()));
            AssertAs<IHasPrice>(car, p => Assert.Equal(TestCarPrice, p.Price()));
            AssertAs<IHasParts>(car, p =>
            {
                Assert.Equal(2, p.Parts().Count());
                Assert.Equal(TestPartType, p.Parts().First().Type());
                Assert.Equal(TestPartModel, p.Parts().Last().Model());
            });
        }

        private static void AssertAs<T>(T model, Action<T> action) => action(model);
    }
}