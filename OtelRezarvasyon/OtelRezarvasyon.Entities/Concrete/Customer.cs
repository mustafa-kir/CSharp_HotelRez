using OtelRezarvasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public int Remainder { get; set; }
        public int CustomerRoomNumber { get; set; }
    }
}
