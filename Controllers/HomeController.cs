using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ozgunneonCom.Data.Abstract;
using ozgunneonCom.Models;

namespace ozgunneonCom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IPhotoTypeRepository _photoTypeRepository;
        IPhotoRepository _photoRepository;
        public HomeController(ILogger<HomeController> logger, IPhotoTypeRepository photoTypeRepository, IPhotoRepository photoRepository)
        {
            _logger = logger;
            _photoRepository = photoRepository;
            _photoTypeRepository = photoTypeRepository;
        }

        public IActionResult Index()
        {
            PhotoAndTypeViewModel p = new PhotoAndTypeViewModel();
            p.photos = _photoRepository.getAllPhotos;
            p.types = _photoTypeRepository.getAllPhotoTypes;
            return View(p);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
