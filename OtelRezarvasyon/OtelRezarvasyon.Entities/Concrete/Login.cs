using OtelRezarvasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entities.Concrete
{
    public class Login:IEntity
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Assignment { get; set; }

    }
}
