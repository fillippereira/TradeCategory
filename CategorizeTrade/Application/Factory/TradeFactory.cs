using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGFT.Domain.Entities;
using TesteGFT.Enum;

namespace TesteGFT.Services
{
    public class TradeFactory : ITradeFactory
    {
        public Trade Create(TradeCategoryEnum tradeCategory)
        {
            return tradeCategory switch
            {
                TradeCategoryEnum.Expired => new Expired(),
                TradeCategoryEnum.MediumRisk => new MediumRisk(),
                TradeCategoryEnum.HighRisk => new HighRisk(),
                _ => null,
            };
        }
    }
}
