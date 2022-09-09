using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGFT.Domain.Entities
{
    public class HighRisk : Trade
    {
        public HighRisk(double value, string clientSector, DateTime nextPaymentDate) : base(value, clientSector, nextPaymentDate)
        {
        }
        public HighRisk()
        {

        }

        public override string GetCategory()
        {
            return "HIGHRISK";
        }
    }
}
