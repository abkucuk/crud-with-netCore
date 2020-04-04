using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ozgunneonCom.Data.Abstract;
using ozgunneonCom.Models;

namespace ozgunneonCom.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IPhotoTypeRepository _photoTypeRepository;
        IPhotoRepository _photoRepository;
        public AdminController(IPhotoTypeRepository photoTypeRepository, IPhotoRepository photoRepository)
        {
            _photoTypeRepository = photoTypeRepository;
            _photoRepository = photoRepository;
        }
        // GET: Admin
        public ActionResult Index()
        {
            PhotoAndTypeViewModel p = new PhotoAndTypeViewModel();
            p.photos = _photoRepository.getAllPhotos;
            p.types = _photoTypeRepository.getAllPhotoTypes;
            return View(p);
        }
        public IActionResult DeletePhoto(string Id) {
            _photoRepository.deletePhoto(_photoRepository.getAllPhotos.FirstOrDefault(k => k.ID == Id));
            return RedirectToAction("index");
        }
        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult addNewType() {
            return View();
        }
        [HttpPost]
        public ActionResult addNewType(PhotoType _type)
        {
            _photoTypeRepository.addPhotoType(_type);
            return RedirectToAction("Index");
        }


        // GET: Admin/addNewPhoto
        public ActionResult addNewPhoto()
        {
            // pntvm = photoAndTypeViewModel kısaltması
            PhotoAndTypeViewModel pntvm = new PhotoAndTypeViewModel();
            pntvm.types = _photoTypeRepository.getAllPhotoTypes;
            return View(pntvm);
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> addNewPhotoAsync(PhotoAndTypeViewModel patvm, IFormFile myFile)
        {
            // TODO: resmin name description ve tür adı bilgileri geliyor fakat idsi gelmiyor.
            try
            {
                Photo _photo = patvm.Photo;
                
                if (myFile != null)
                {
                    string guidForEndOfTheImageName = Guid.NewGuid().ToString();
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", guidForEndOfTheImageName +"."+ myFile.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await myFile.CopyToAsync(stream);

                        _photo.photoName = guidForEndOfTheImageName+"." + myFile.FileName  ;
                    }
                }
                //patvm.Photo.photoType.Name = _photoTypeRepository.getAllPhotoTypes.FirstOrDefault(m => m.Id == patvm.Photo.photoType.Id).Name;
                //patvm.Photo.photoType.Photos = new List<Photo>();
                //_photo.photoTypeId = patvm.Photo.photoType.Id;
                _photoRepository.addPhoto(_photo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}