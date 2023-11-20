using OtelRezarvasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OtelRezarvasyon.Entities.Concrete
{
    //çalısanlara görev ekleme yap
    public class Boss : IEntity
    {
        public int BossId { get; set; }
        public string BossName { get; set; }
        public string BossPassword { get; set; }

    }
}
