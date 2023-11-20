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
    public class BossManager : IBossService
    {
        /// <summary>
        /// 1. Buranın roomdan implementasyon yapılmasının sebebi çünkü sadece odalar tablosunda değişiklik yapılacak olmasından.
        /// 2. çalısanlara görev ekleme yap
        /// </summary>
        
        private IRoomDal _roomDal;
        private IEmployeeDal _employeeDal;
        // bu IEmployeeDal burada sadece çalısanın görev atamsı yapacak

        public BossManager(IRoomDal roomDal, IEmployeeDal employeeDal)
        {
            _roomDal = roomDal;
            _employeeDal = employeeDal;
        }

        public void Add(Room room)
        {
           _roomDal.Add(room);
        }

        public void Delete(Room room)
        {
           _roomDal.Delete(room);
        }

        public List<Room> GetAll()
        {
            return _roomDal.GetAll();
        }
        //bu kalkabilir filitrelemeye gerek yok
        public List<Room> GetRoomsByRoomNumber(int roomNumber)
        {
            return _roomDal.GetAll(p => p.RoomNumber == roomNumber);
        }

        public void Update(Room room)
        {
            _roomDal.Update(room);

        }

        // görev ataması yapılacak
        public void Assign(Employee assign)
        {
            _employeeDal.Update(assign);// görev ataması yapıldı. buraya bir daha bak !!! çünkü sadece çalısan talosunun görev bölümü değiştirilecek.
        }
    }
}
