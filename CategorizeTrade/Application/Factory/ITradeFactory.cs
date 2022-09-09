using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGFT.Domain.Entities;
using TesteGFT.Enum;

namespace TesteGFT.Services
{
    internal interface ITradeFactory
    {
        Trade Create(TradeCategoryEnum tradeCategory);
    }
}
