using ozgunneonCom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozgunneonCom.Data.Abstract
{
    public interface IPhotoRepository
    {
        IQueryable<Photo> getAllPhotos { get; }
        void addPhoto(Photo _photo);
        void deletePhoto(Photo _photo);
    }
}
