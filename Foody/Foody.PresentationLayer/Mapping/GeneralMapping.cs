using AutoMapper;
using Foody.DTOLayer.Dtos.About;
using Foody.DTOLayer.Dtos.Slider;
using Foody.EntityLayer.Concrete;

namespace Foody.PresentationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<ResultAbout, About>().ReverseMap();
            CreateMap<CreateAbout, About>().ReverseMap();
            CreateMap<GetByIdAbout, About>().ReverseMap();
            CreateMap<UpdateAbout, About>().ReverseMap();

            CreateMap<ResultSlider, Slider>().ReverseMap();
            CreateMap<CreateSlider, Slider>().ReverseMap();
            CreateMap<GetByIdSlider, Slider>().ReverseMap();
            CreateMap<UpdateSlider, Slider>().ReverseMap();
        }
    }
}
