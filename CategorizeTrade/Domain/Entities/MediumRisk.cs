using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGFT.Domain.Entities
{
    public class MediumRisk : Trade
    {
        public MediumRisk(double value, string clientSector, DateTime nextPaymentDate) : base(value, clientSector, nextPaymentDate)
        {
        }
        public MediumRisk()
        {

        }

        public override string GetCategory()
        {
            return "MEDIUMRISK";
        }
    }
}
