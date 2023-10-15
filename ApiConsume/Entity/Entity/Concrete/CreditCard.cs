using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CreditCard
    {
        public int CreditCardID { get; set; }
        public int CreditCardNumber { get; set; }
        public string CreditCardOwner { get; set; }
        public bool BorcStatus { get; set; }
    }
}
