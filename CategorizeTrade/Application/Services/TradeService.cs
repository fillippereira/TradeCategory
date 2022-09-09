using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGFT.Enum;
using TesteGFT.Helpers;

namespace CategorizeTrade.Application.Services
{
    public class TradeService : ITradeService
    {
        public TradeCategoryEnum? GetTradeCategory(string referenceDate, string[] linePortifolio)
        {
            var value = Convert.ToDouble(linePortifolio[0]);
            var clientSector = linePortifolio[1].ToUpper();
            var nextPaymentDate = DateHelper.ConvertStringToDate(linePortifolio[2]);

            if (nextPaymentDate < DateHelper.ConvertStringToDate(referenceDate).AddDays(30))
            {
                return TradeCategoryEnum.Expired;
            }

            if (clientSector.Equals("PRIVATE") && value > 1000000)
            {
                return TradeCategoryEnum.HighRisk;
            }

            if (clientSector.Equals("PUBLIC") && value > 1000000)
            {
                return TradeCategoryEnum.MediumRisk;
            }

            //TODO - Implement exception for Category not found
            return null;
        }
    }
}
