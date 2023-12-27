using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;

namespace _2_03_2023_nevsehir_mvc.Services
{
  public class SqlGezilecekYerlerTableRepository : IGezilecekYerlerTableRepository
  {
    private readonly nevsehirDbContext _context;

    public SqlGezilecekYerlerTableRepository(nevsehirDbContext context)
    {
      _context = context;
    }

    public bool DeleteGYer(int id)
    {
      gezilecekYerlerTable kayit = _context.gezilecekYerlerTable.FirstOrDefault(x => x.id == id);
      _context.gezilecekYerlerTable.Remove(kayit);
      _context.SaveChanges();
      return true;

    }

    public List<detayResim> DetayResimGetir(int id)
    {
      var kayitlar = _context.detayResim.Where(x => x.sehirId == id).ToList();
      return kayitlar;
    }

    public bool GYerDetayResimEkle(detayResim model)
    {
      _context.detayResim.Add(model);
      _context.SaveChanges();
      return true;
    }

    public gezilecekYerlerTable GYerGetir(int id)
    {
      gezilecekYerlerTable kayit = _context.gezilecekYerlerTable.FirstOrDefault(x => x.sehirId == id);
      return kayit;
    }

    public bool NewGYer(gezilecekYerlerTable model)
    {
      _context.gezilecekYerlerTable.Add(model);
      _context.SaveChanges();
      return true;
    }

    public List<gezilecekYerlerTable> sehirGYer(int id)
    {
      var kayitlar = _context.gezilecekYerlerTable.Where(x => x.sehirId == id).ToList();
      return kayitlar;
    }

    public List<gezilecekYerlerTable> ToList()
    {
      var kayitlar = _context.gezilecekYerlerTable.ToList();
      return kayitlar;
    }

    public bool UpdateGYer(gezilecekYerlerTable model)
    {
      gezilecekYerlerTable kayit = _context.gezilecekYerlerTable.Find(model.id);
      kayit.gYerAd = model.gYerAd;
      kayit.gYerAciklama = model.gYerAciklama;
      kayit.gYerResim = model.gYerResim;
      _context.gezilecekYerlerTable.Update(kayit);
      _context.SaveChanges();
      return true;
    }
  }
}