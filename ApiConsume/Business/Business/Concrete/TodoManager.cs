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
    public class TodoManager : ITodoService
    {
        private readonly ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public void TDelete(Todo t)
        {
            _todoDal.Delete(t);
        }

        public Todo TGetById(int id)
        {
            return _todoDal.GetById(id);
        }

        public List<Todo> TGetList()
        {
            return _todoDal.GetList();
        }

        public void TInsert(Todo t)
        {
            _todoDal.Insert(t);
        }

        public void TUpdate(Todo t)
        {
            _todoDal.Update(t);
        }
    }
}
