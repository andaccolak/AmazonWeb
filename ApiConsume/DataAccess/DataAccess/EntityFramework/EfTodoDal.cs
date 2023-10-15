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
    public class EfTodoDal : GenericRepository<Todo>, ITodoDal
    {
        public EfTodoDal(Context context) : base(context) { }
    }
}
