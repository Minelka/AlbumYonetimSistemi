using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_BLL.Models
{
    //Admin için özel olan proplar burada yer alır. Görüntülenme yapılabilmesi için model oluşturulur.
    public class AdminModel : BaseModel
    {
        public string Name { get; set; }

        public string Password { get; set; }
    }
}
