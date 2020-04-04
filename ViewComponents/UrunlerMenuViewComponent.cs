using Microsoft.AspNetCore.Mvc;
using ozgunneonCom.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozgunneonCom.ViewComponents
{
    [ViewComponent]
    public class UrunlerMenuViewComponent: ViewComponent
    {
        IPhotoTypeRepository _photoTypeRepository;
        public UrunlerMenuViewComponent(IPhotoTypeRepository photoTypeRepository)
        {
            _photoTypeRepository = photoTypeRepository;
        }
        public IViewComponentResult Invoke() {
            return View(_photoTypeRepository.getAllPhotoTypes);
        }
    }
}
