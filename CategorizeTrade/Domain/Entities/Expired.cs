using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGFT.Domain.Entities
{
    public class Expired : Trade
    {
        public Expired(double value, string clientSector, DateTime nextPaymentDate) : base(value, clientSector, nextPaymentDate)
        {
        }
        public Expired()
        {

        }

        public override string GetCategory()
        {
            return "EXPIRED";
        }
    }
}
