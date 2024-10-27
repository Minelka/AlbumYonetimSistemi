using AYS_DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Entities.Concrete
{
    //Admin sınıfına ait roplar burada yer alır.
    public class Admin : BaseEntity
    {
        [Column(TypeName = "nvarchar(25)")]
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
