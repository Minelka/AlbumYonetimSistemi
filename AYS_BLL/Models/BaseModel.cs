using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_BLL.Models
{
    //Ortak proplar burada verilir. Görüntülenme yapılabilmesi için model oluşturulur.
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
