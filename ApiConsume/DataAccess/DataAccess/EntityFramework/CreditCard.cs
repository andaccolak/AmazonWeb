using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfCreditCardDal : GenericRepository<CreditCard>, ICreditCardDal
    {
        public EfCreditCardDal(Context context) : base(context) { }
    }
}
