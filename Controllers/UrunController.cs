using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ozgunneonCom.Data.Abstract;

namespace ozgunneonCom.Controllers
{
    public class UrunController : Controller
    {
        IPhotoTypeRepository _photoTypeRepository;
        IPhotoRepository _photoRepository;
        public UrunController(IPhotoTypeRepository photoTypeRepository, IPhotoRepository photoRepository)
        {
            _photoTypeRepository = photoTypeRepository;
            _photoRepository = photoRepository;
        }
        public IActionResult Index(string id)
        {
            
            return View(_photoRepository.getAllPhotos.Where( k => k.photoTypeId == id));
        }
    }
}