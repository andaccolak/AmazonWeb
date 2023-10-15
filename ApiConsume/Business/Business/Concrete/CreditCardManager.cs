using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        private readonly ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public void TDelete(CreditCard t)
        {
            _creditCardDal.Delete(t);
        }

        public CreditCard TGetById(int id)
        {
            return _creditCardDal.GetById(id);
        }

        public List<CreditCard> TGetList()
        {
            return _creditCardDal.GetList();
        }

        public void TInsert(CreditCard t)
        {
            _creditCardDal.Insert(t);
        }

        public void TUpdate(CreditCard t)
        {
            _creditCardDal.Update(t);
        }
    }
}
