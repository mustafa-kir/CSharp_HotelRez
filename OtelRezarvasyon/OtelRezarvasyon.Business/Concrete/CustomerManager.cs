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
    public class CustomerManager : ICustomerService
    {
        private IRoomDal _roomDal;
        private IReservedRoomsDal _reservedRoomsDal;

        public CustomerManager(IRoomDal roomDal, IReservedRoomsDal reservedRoomsDal)
        {
            _roomDal = roomDal;
            _reservedRoomsDal = reservedRoomsDal;
        }

        public void Add(ReservedRooms reservedRooms)
        {
            _reservedRoomsDal.Add(reservedRooms);
        }

        public void Delete(ReservedRooms reservedRooms)
        {
            try
            {
                _reservedRoomsDal.Delete(reservedRooms);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");
            }
        }

        public List<ReservedRooms> GetAll(int reservedRoomsId)
        {
            return _reservedRoomsDal.GetAll(p => p.ReservedRoomId == reservedRoomsId);
        }

        public List<Room> GetAll()
        {
           return _roomDal.GetAll();
        }

        public List<Room> GetRoomsByRoomCapacity(int roomCapacityFilter)
        {
            return _roomDal.GetAll(p => p.NumberOfGuests == roomCapacityFilter);
        }

        public List<Room> GetRoomsByRoomDayPrice(int roomDayPriceFilter)
        {
             return _roomDal.GetAll(p => p.RoomDayRate <= roomDayPriceFilter);
        }

        public void Update(ReservedRooms reservedRooms)
        {
            _reservedRoomsDal.Update(reservedRooms);
        }
    }
}
