using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DataAccess.Abstract
{
    public interface IReservedRoomsDal: IEntityRepository<ReservedRooms>
    {
    }
}
