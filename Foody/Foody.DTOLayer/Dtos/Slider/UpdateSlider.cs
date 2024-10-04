using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DTOLayer.Dtos.Slider
{
    public class UpdateSlider
    {
        public int SliderId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
