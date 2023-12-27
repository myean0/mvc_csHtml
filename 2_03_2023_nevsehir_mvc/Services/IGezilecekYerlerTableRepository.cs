using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;

namespace _2_03_2023_nevsehir_mvc.Services
{
    public interface IGezilecekYerlerTableRepository
    {
        public bool NewGYer(gezilecekYerlerTable model);
        public bool UpdateGYer(gezilecekYerlerTable model);
        public bool GYerDetayResimEkle(detayResim model);
        public List<detayResim> DetayResimGetir(int id);
        public bool DeleteGYer(int id);
        public gezilecekYerlerTable GYerGetir(int id);
        public List<gezilecekYerlerTable> ToList();
        public List<gezilecekYerlerTable> sehirGYer(int id);
    }
}