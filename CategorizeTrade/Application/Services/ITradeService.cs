using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGFT.Enum;

namespace CategorizeTrade.Application.Services
{
    internal interface ITradeService
    {
        TradeCategoryEnum? GetTradeCategory(string referenceDate, string[] linePortifolio);
    }
}
