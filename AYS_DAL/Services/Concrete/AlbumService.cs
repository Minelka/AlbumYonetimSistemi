using AYS_DAL.Entities.Concrete;
using AYS_DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Services.Concrete
{
    public class AlbumService<TModel> : Service<TModel, Album> where TModel : class
    {
        public AlbumService()
        {
            _repository = _unitOfWork.Albums;
        }
    }
}
