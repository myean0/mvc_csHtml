using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;

namespace _2_03_2023_nevsehir_mvc.Services
{
  public class SqlSehirTableRepository : ISehirTableRepository
  {
    private readonly nevsehirDbContext _context;

    public SqlSehirTableRepository(nevsehirDbContext context)
    {
      _context = context;
    }

    public bool DeleteSehir(int id)
    {
      sehirTable kayit = _context.sehirTable.FirstOrDefault(x => x.Id == id);
      _context.sehirTable.Remove(kayit);
      _context.SaveChanges();
      return true;
    }

    public bool UpdateSehir(sehirTable model)
    {
      sehirTable kayit = _context.sehirTable.Find(model.Id);
      kayit.Sehir = model.Sehir;
      kayit.SehirAciklama = model.SehirAciklama;
      _context.sehirTable.Update(kayit);
      _context.SaveChanges();
      return true;
    }

    public bool NewSehir(sehirTable sehir)
    {
      _context.sehirTable.Add(sehir);
      _context.SaveChanges();
      return true;
    }

    public sehirTable SehirGetir(int id)
    {
      var kayit = _context.sehirTable.FirstOrDefault(x => x.Id == id);
      return (kayit);
    }

    public List<sehirTable> ToList()
    {
      var kayitlar = _context.sehirTable.ToList();
      return kayitlar;
    }

  }
}