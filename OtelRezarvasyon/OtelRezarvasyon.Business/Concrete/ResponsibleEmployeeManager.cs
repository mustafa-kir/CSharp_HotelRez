using OtelRezarvasyon.Business.Abstract;
using OtelRezarvasyon.DataAccess.Abstract;
using OtelRezarvasyon.DataAccess.Concrete.EntityFramework;
using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Concrete
{
    public class ResponsibleEmployeeManager : IResponsibleEmployeeService
    {
        private IReservedRoomsDal _reservedRoomsDal;

        public ResponsibleEmployeeManager(EfReservedRoomsDal reservedRoomsDal )
        {
            _reservedRoomsDal = reservedRoomsDal;
        }

        public void Update(ReservedRooms reservedRooms)
        {
            _reservedRoomsDal.Update(reservedRooms);
        }

        List<ReservedRooms> IResponsibleEmployeeService.GetAll()
        {
            return _reservedRoomsDal.GetAll();
        }
    }
}
