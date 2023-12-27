using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;

namespace _2_03_2023_nevsehir_mvc.Services
{
    public interface ISliderTableRepository
    {
        public bool NewSlider(sliderTable slider); // Slider Ekleme 
        public bool DeleteSlider(int id); // Slider Silme
        public bool UpdateSlider(sliderTable model); // Slider GÜncelleme
        public sliderTable SliderGetir(int id); // 1 Kayıtlı Slider Listeleme
        public List<sliderTable> ToList(); // Slider Listeleme
        public List<sliderTable> sehirSlider(int id); // Şehir Slider
    }
}