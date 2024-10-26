using AYS_DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Entities.Concrete
{
    public class Album : BaseEntity
    {
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Artist { get; set; }
        public DateOnly ReleaseDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Discount { get; set; }
        public bool Status { get; set; }
    }
}
