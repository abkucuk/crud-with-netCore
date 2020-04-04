using ozgunneonCom.Data.Abstract;
using ozgunneonCom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozgunneonCom.Data.Concrete
{
    public class EfPhotoTypeRepository : IPhotoTypeRepository
    {
        private ApplicationDbContext _context;
        public EfPhotoTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<PhotoType> getAllPhotoTypes => _context.PhotoTypes;

        public void addPhotoType(PhotoType _photoType)
        {
            _context.Add(_photoType);
            _context.SaveChanges();
        }

        public void deletePhotoType(PhotoType _photoType)
        {
            _context.Remove(_photoType);
            _context.SaveChanges();
        }
    }
}
