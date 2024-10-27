using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Entities.Abstract
{
    //CRUD işlemler interface ile verilir.
    public interface IEntity
    {
            public int Id { get; set; }
            public bool IsActive { get; set; }
            public DateTime Created { get; set; }
            public DateTime? Modified { get; set; }
            public DateTime? Deleted { get; set; }
    }
}
