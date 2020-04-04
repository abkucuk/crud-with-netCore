using ozgunneonCom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozgunneonCom.Data.Abstract
{
    public interface IPhotoTypeRepository
    {
        IQueryable<PhotoType> getAllPhotoTypes { get; }
        void addPhotoType(PhotoType _photoType);
        void deletePhotoType(PhotoType _photoType);
    }
}
