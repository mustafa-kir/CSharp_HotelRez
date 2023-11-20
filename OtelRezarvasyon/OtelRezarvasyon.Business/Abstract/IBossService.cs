using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Abstract
{
    public interface IBossService
    {
        List<Room> GetAll(); // tüm odalar listelensin
        List<Room> GetRoomsByRoomNumber(int roomNumber); // odalar oda idsine göre yada oda numarsına göre listelensin
        void Add(Room room); // yeni oda eklensin
        void Update(Room room); // oda durumu güncenlesin
        void Delete(Room room); // oda silinsin.
        
    }
}
