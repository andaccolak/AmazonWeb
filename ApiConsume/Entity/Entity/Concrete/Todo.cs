using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Todo
    {
        public int TodoID { get; set; }
        public string TodoStatus { get; set; }
        public string TodoDescription { get; set; }
        public string TodoType { get; set;}
    }
}
