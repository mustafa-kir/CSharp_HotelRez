using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Abstract
{
    public interface IResponsibleEmployeeService
    {
        List<ReservedRooms> GetAll();
        void Update(ReservedRooms reservedRooms); // oda durumunda sadece onay durmunu güncenlesin
        
    }
}
