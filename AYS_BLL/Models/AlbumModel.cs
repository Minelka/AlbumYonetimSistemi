using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_BLL.Models
{
    //Album için özel olan proplar burada yer alır. Görüntülenme yapılabilmesi için model oluşturulur.
    public class AlbumModel : BaseModel
    {
        public string Name { get; set; }

        public string Artist { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public bool Status { get; set; }
    }
}
