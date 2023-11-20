using OtelRezarvasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entities.Concrete
{
    public class Room : IEntity
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime DateRange { get; set; }
        public bool ConfirmationStatus { get; set; }
        public string ResponsibleEmployee { get; set; }
        public int RoomDayRate { get; set; }
    }
}
