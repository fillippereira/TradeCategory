using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGFT.Interfaces;

namespace TesteGFT.Domain.Entities
{
    public abstract class Trade : ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public abstract string GetCategory();

        public Trade()
        {

        }

        public Trade(double value, string clientSector, DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }        
    }
}
