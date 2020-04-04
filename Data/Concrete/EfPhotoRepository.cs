using ozgunneonCom.Data.Abstract;
using ozgunneonCom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozgunneonCom.Data.Concrete
{
    public class EfPhotoRepository:IPhotoRepository
    {
        private ApplicationDbContext _context;
        public EfPhotoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Photo> getAllPhotos => _context.Photos;
        public void addPhoto(Photo _photo)
        {
            _context.Add(_photo);
            _context.SaveChanges();
        }

        public void deletePhoto(Photo _photo)
        {
            _context.Remove(_photo);
            _context.SaveChanges();
        }
    }

}
