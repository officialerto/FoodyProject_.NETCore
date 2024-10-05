using AutoMapper;
using Food.BusinessLayer.Abstract;
using Foody.DTOLayer.Dtos.Slider;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public IActionResult SliderList()
        {
            var values = _sliderService.TGetAll();
            return View(_mapper.Map<List<ResultSlider>>(values));
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateSlider(CreateSlider createSlider)
        {
            var value = _mapper.Map<Slider>(createSlider);
            _sliderService.TInsert(value);

            return RedirectToAction("SliderList");
        }

        public IActionResult Deleteslider(int id)
        {
            _sliderService.TDelete(id);
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var values = _sliderService.TGetById(id);
            return View(_mapper.Map<GetByIdSlider>(values));
        }

        [HttpPost]
        public IActionResult UpdateSlider(UpdateSlider updateSlider)
        {
            var value = _mapper.Map<Slider>(updateSlider);
            _sliderService.TUpdate(value);

            return RedirectToAction("SliderList");
        }

    }
}
