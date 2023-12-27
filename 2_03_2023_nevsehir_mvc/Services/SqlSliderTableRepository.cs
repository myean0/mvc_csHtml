using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;

namespace _2_03_2023_nevsehir_mvc.Services
{
    public class SqlSliderTableRepository : ISliderTableRepository
    {

        private readonly nevsehirDbContext _context;

        public SqlSliderTableRepository(nevsehirDbContext context)
        {
            _context = context;
        }

        public bool DeleteSlider(int id)
        {
            sliderTable kayit = _context.sliderTable.FirstOrDefault(x => x.Id == id);
            _context.sliderTable.Remove(kayit);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateSlider(sliderTable model)
        {
            sliderTable kayit = _context.sliderTable.Find(model.Id);
            kayit.SliderBaslik = model.SliderBaslik;
            kayit.SliderAciklama = model.SliderAciklama;
            kayit.SliderResim = model.SliderResim;
            _context.sliderTable.Update(kayit);
            _context.SaveChanges();
            return true;
        }

        public bool NewSlider(sliderTable slider)
        {
            _context.sliderTable.Add(slider);
            _context.SaveChanges();
            return true;
        }

        public List<sliderTable> ToList()
        {
            var kayitlar = _context.sliderTable.ToList();
            return kayitlar;
        }

        public sliderTable SliderGetir(int id)
        {
            sliderTable kayit = _context.sliderTable.FirstOrDefault(x => x.Id == id);
            return kayit;
        }

        public List<sliderTable> sehirSlider(int id)
        {
            var kayitlar = _context.sliderTable.Where(x => x.sehirId == id).ToList();
            return kayitlar;
        }
    }
}