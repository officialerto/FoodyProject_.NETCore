using AutoMapper;
using Food.BusinessLayer.Abstract;
using Foody.DTOLayer.Dtos.About;
using Foody.DTOLayer.Dtos.Slider;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class AboutsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAboutService _aboutService;

        public AboutsController(IMapper mapper, IAboutService aboutService)
        {
            _mapper = mapper;
            _aboutService = aboutService;
        }

        public IActionResult AboutList()
        {
            var values = _aboutService.TGetAll();
            return View(_mapper.Map<List<ResultAbout>>(values));
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAbout createAbout)
        {
            var value = _mapper.Map<About>(createAbout);
            _aboutService.TInsert(value);

            return RedirectToAction("AboutList");
        }

        public IActionResult Deleteabout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            return View(_mapper.Map<GetByIdAbout>(values));
        }

        [HttpPost]
        public IActionResult UpdateAbout(UpdateAbout updateAbout)
        {
            var value = _mapper.Map<About>(updateAbout);
            _aboutService.TUpdate(value);

            return RedirectToAction("AboutList");
        }
    }
}
