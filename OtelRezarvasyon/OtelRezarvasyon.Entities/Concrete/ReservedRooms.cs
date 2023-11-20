using OtelRezarvasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entities.Concrete
{
    public class ReservedRooms:IEntity
    {
        public int ReservedRoomId { get; set; }
        public bool RoomConfirm { get; set; } // oda kapasitesi
        public int RoomId { get; set; }
        public string CustomerId { get; set; }
    }
}
