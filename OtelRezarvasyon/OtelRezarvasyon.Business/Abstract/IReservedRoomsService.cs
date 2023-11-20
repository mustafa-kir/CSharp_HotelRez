using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Abstract
{
    public interface IReservedRoomsService
    {
        List<ReservedRooms> GetAll(int reservedRoomsId); // tutulan oda gösterilsin.
        void Update(ReservedRooms reservedRooms); // Tutulan oda güncellensin.
        void Add(ReservedRooms reservedRooms); // tutulan oda tablosuna, tutulan odayı kaydetsin.
        void Delete(ReservedRooms reservedRooms); // tutulan oda silinsin.
    }
}
