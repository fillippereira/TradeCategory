using CategorizeTrade.Application.Services;
using Moq;
using TesteGFT.Services;
using Xunit;

namespace CategorizeTrade.Test
{
    public class TradeTest
    {
        [Fact]
        public void TradeWithCategoryExpired()
        {
            //Arrange
            var referenceDate = "12/11/2020";
            var portifolioLine = "400000 Public 07/01/2020";

            //Act
            var mockTradeService = new Mock<TradeService>().Object;
            var mockTradeFactory = new Mock<TradeFactory>().Object;

            var tradeCategory = mockTradeService.GetTradeCategory(referenceDate, portifolioLine.Split(" "));
            var result = mockTradeFactory.Create((TesteGFT.Enum.TradeCategoryEnum)tradeCategory).GetCategory();

            //Assert
            Assert.Equal("EXPIRED", result);
        }

        [Fact]
        public void TradeWithCategoryHighRisk()
        {
            //Arrange
            var referenceDate = "12/11/2020";
            var portifolioLine = "2000000 Private 12/29/2025";

            //Act
            var mockTradeService = new Mock<TradeService>().Object;
            var mockTradeFactory = new Mock<TradeFactory>().Object;

            var tradeCategory = mockTradeService.GetTradeCategory(referenceDate, portifolioLine.Split(" "));
            var result = mockTradeFactory.Create((TesteGFT.Enum.TradeCategoryEnum)tradeCategory).GetCategory();

            //Assert
            Assert.Equal("HIGHRISK", result);
        }
        [Fact]
        public void TradeWithCategoryMediumRisk()
        {
            //Arrange
            var referenceDate = "12/11/2020";
            var portifolioLine = "5000000 Public 01/02/2024";

            //Act
            var mockTradeService = new Mock<TradeService>().Object;
            var mockTradeFactory = new Mock<TradeFactory>().Object;

            var tradeCategory = mockTradeService.GetTradeCategory(referenceDate, portifolioLine.Split(" "));
            var result = mockTradeFactory.Create((TesteGFT.Enum.TradeCategoryEnum)tradeCategory).GetCategory();

            //Assert
            Assert.Equal("MEDIUMRISK", result);
        }
    }
}