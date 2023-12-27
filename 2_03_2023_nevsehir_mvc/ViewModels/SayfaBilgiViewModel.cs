using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;

namespace _2_03_2023_nevsehir_mvc.ViewModels
{
    public class SayfaBilgiViewModel
    {
        public IEnumerable<sehirTable> Sehirler { get; set; }
        public IEnumerable<sliderTable> Sliderlar { get; set; }
        public IEnumerable<gezilecekYerlerTable> GezilecekYerler { get; set; }
        public IEnumerable<detayResim> DetayResimler { get; set; }
        public sehirTable sehirTableKayit { get; set; }
        public sliderTable sliderTableKayit { get; set; }
        public gezilecekYerlerTable gezilecekYerlerKayit { get; set; }
        public detayResim detayResimKayit { get; set; }
    }
}