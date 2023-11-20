using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Abstract
{
    public interface ICustomerService
    {
        // müsterinin yapacağı işlemler fonksiyonları.
        List<Room> GetAll(); // tüm odalar listelenmesi; çünkü hangi odayı tutacağını görsün.
        List<Room> GetRoomsByRoomCapacity(int RoomCapacityFilter);
        List<Room> GetRoomsByRoomDayPrice(int RoomDayPriceFilter);
        

        
    }
}
