using NuGet.Frameworks;
using ResponsiveWebAppBrannen.Models;

namespace ResponsiveWebAppTest
{
    public class ResponsiveWebTest
    {
        [Fact]
        public void ValidInputCalculation()
        {
            var model = new BirthAgeModel { Name = "Jim", BirthYear = 1998 };

            string result = model.ageThisYear();

            Assert.Equal("Jim will be 27 by Dec 31st of this year.", result);
        }

        [Theory]
        [InlineData("Jim27")]
        [InlineData("452-/")]
        public void InvalidName(string name)
        {
            var exception = Record.Exception(() =>
            {
                var model = new BirthAgeModel { Name = name, BirthYear = 1998 };
            });
            Assert.Null(exception);
        }
        [Fact]
        public void BirthYearNull()
        {
            var model = new BirthAgeModel { Name = "Jim", BirthYear = null };

            Assert.Throws<InvalidOperationException>(() => model.ageThisYear());
        }
        [Fact]
        public void BirthYearEdgeCaseHigh()
        {
            var model = new BirthAgeModel { Name = "Jim", BirthYear = 2024 };

            string result = model.ageThisYear();

            Assert.Equal("Jim will be 1 by Dec 31st of this year.", result);
        }
        [Fact]
        public void BirthYearEdgeCaseLow()
        {
            var model = new BirthAgeModel { Name = "Jim", BirthYear = 1 };

            string result = model.ageThisYear();

            Assert.Equal("Jim will be 2024 by Dec 31st of this year.", result);
        }
    }
}