using OtelRezarvasyon.Business.Abstract;
using OtelRezarvasyon.DataAccess.Abstract;
using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Concrete
{
    public class ReservedRoomsManager : IReservedRoomsService
    {
        private IReservedRoomsDal _reservedRoomsDal;

        public ReservedRoomsManager(IReservedRoomsDal reservedRoomsDal)
        {
            _reservedRoomsDal = reservedRoomsDal;
        }

        public void Add(ReservedRooms reservedRooms)
        {
            _reservedRoomsDal.Add(reservedRooms);
        }

        public void Delete(ReservedRooms reservedRooms)
        {
            _reservedRoomsDal.Delete(reservedRooms);
        }

        public List<ReservedRooms> GetAll(int reservedRoomsId)
        {
            return _reservedRoomsDal.GetAll(p => p.ReservedRoomId ==reservedRoomsId);///
        }

        public void Update(ReservedRooms reservedRooms)
        {
            _reservedRoomsDal.Update(reservedRooms);
        }
    }
}
