using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;

namespace _2_03_2023_nevsehir_mvc.Services
{
  public interface ISehirTableRepository
  {
    public bool NewSehir(sehirTable sehir);
    public bool UpdateSehir(sehirTable model);
    public bool DeleteSehir(int id);
    public sehirTable SehirGetir(int id);
    public List<sehirTable> ToList();
  }
}