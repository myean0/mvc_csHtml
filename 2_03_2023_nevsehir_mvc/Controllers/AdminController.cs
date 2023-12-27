using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;
using _2_03_2023_nevsehir_mvc.Services;
using _2_03_2023_nevsehir_mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using X.PagedList;

namespace _2_03_2023_nevsehir_mvc.Controllers
{
  public class AdminController : Controller
  {
    private readonly ISliderTableRepository _sliderRepository;
    private readonly ISehirTableRepository _sehirRepository;
    private readonly IGezilecekYerlerTableRepository _gYerRepository;

    public AdminController(ISliderTableRepository repository, ISehirTableRepository repository1, IGezilecekYerlerTableRepository repository2)
    {
      _sliderRepository = repository;
      _sehirRepository = repository1;
      _gYerRepository = repository2;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult SliderListele(int page = 1)
    {
      var kayitlar = _sliderRepository.ToList();
      return View(kayitlar.ToPagedList(page, 3));
    }
    public IActionResult SehirListele(int page = 1)
    {
      var kayitlar = _sehirRepository.ToList();
      return View(kayitlar.ToPagedList(page, 3));
    }

    public IActionResult SehirVeriGirisi()
    {
      return View();
    }

    [HttpPost]
    public IActionResult SehirVeriGirisi(sehirTable model)
    {
      _sehirRepository.NewSehir(model);
      return RedirectToAction("Index", "Admin");
    }

    public IActionResult SehirGuncelle(int id)
    {
      var kayit = _sehirRepository.SehirGetir(id);
      return View(kayit);
    }

    [HttpPost]
    public IActionResult SehirGuncelle(sehirTable model)
    {
      _sehirRepository.UpdateSehir(model);
      return RedirectToAction("SehirListele");
    }

    public IActionResult SehirSil(int id)
    {
      var kayit = _sehirRepository.SehirGetir(id);
      return View(kayit);
    }

    [HttpPost, ActionName("SehirSil")]
    public IActionResult SilSehir(int id)
    {
      _sehirRepository.DeleteSehir(id);
      return RedirectToAction("SehirListele");
    }

    public IActionResult SliderGuncelle(int id)
    {
      var kayit = _sliderRepository.SliderGetir(id);
      return View(kayit);
    }

    [HttpPost]
    public async Task<IActionResult> SliderGuncelle(sliderTable model, IFormFile resim)
    {
      if (resim != null)
      {
        var silinecekDosya = Path.Combine(
            Directory.GetCurrentDirectory(),
            @"wwwroot",
            "img",
            model.SliderResim
        );
        System.IO.File.Delete(silinecekDosya);

        string dosyaAdi = Guid.NewGuid() + "_" + resim.FileName;
        string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "img", dosyaAdi);
        using (var stream = new FileStream(path, FileMode.Create))
        {
          await resim.CopyToAsync(stream);
        }
        model.SliderResim = dosyaAdi;
      }
      _sliderRepository.UpdateSlider(model);
      return RedirectToAction("SliderListele");
    }

    public IActionResult SliderSil(int id)
    {
      var kayit = _sliderRepository.SliderGetir(id);
      return View(kayit);
    }

    [HttpPost, ActionName("SliderSil")]
    public IActionResult Sil(int id)
    {
      var kayit = _sliderRepository.SliderGetir(id);
      if (kayit.SliderResim != null)
      {
        var silinecekDosya = Path.Combine(
            Directory.GetCurrentDirectory(),
            @"wwwroot",
            "img",
            kayit.SliderResim
        );
        System.IO.File.Delete(silinecekDosya);
      }
      _sliderRepository.DeleteSlider(id);
      return RedirectToAction("SliderListele");
    }

    public IActionResult SliderVeriGirisi()
    {
      var sehir = _sehirRepository.ToList();
      var slider = _sliderRepository.ToList();

      SayfaBilgiViewModel viewModel = new()
      {
        Sehirler = sehir,
        Sliderlar = slider,
      };
      return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> SliderVeriGirisi(sliderTable slider, IFormFile resim)
    {
      string fileName = Guid.NewGuid() + " " + resim.FileName;
      string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "img", fileName);
      using (var stream = new FileStream(path, FileMode.Create))
      {
        await resim.CopyToAsync(stream);
      }
      slider.SliderResim = fileName;
      _sliderRepository.NewSlider(slider);
      return RedirectToAction("Index", "Admin", new { id = slider.sehirId });

      // return View();
    }

    public IActionResult GYerListele(int page = 1)
    {
      var kayitlar = _gYerRepository.ToList();
      return View(kayitlar.ToPagedList(page, 3));
    }

    public IActionResult GYerVeriGirisi()
    {
      var sehir = _sehirRepository.ToList();
      var gYer = _gYerRepository.ToList();

      SayfaBilgiViewModel viewModel = new()
      {
        Sehirler = sehir,
        GezilecekYerler = gYer
      };
      return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> GYerVeriGirisi(gezilecekYerlerTable gYer, IFormFile resim, List<IFormFile> resimler)
    {
      string fileName="";
      if (resim!=null)
      {
        fileName = Guid.NewGuid() + " " + resim.FileName;
        string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "img", fileName);
        using (var stream = new FileStream(path, FileMode.Create))
        {
          await resim.CopyToAsync(stream);
        }
      }
        
      gYer.gYerResim = fileName;
      _gYerRepository.NewGYer(gYer);

      foreach (var item in resimler)
      {
        string dosyaadi1 = Guid.NewGuid() + "_" + item.FileName;
        string path1 = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "img", dosyaadi1);
        using Stream stream = new FileStream(path1, FileMode.Create);
        item.CopyTo(stream);

        detayResim dr = new detayResim();
        dr.detayResimYolu = dosyaadi1;
        dr.sehirId = gYer.sehirId;
        _gYerRepository.GYerDetayResimEkle(dr);
      }

      return RedirectToAction("Index", "Admin", new { id = gYer.sehirId });
    }

    public IActionResult GYerGuncelle(int id)
    {
      var kayit = _gYerRepository.GYerGetir(id);
      return View(kayit);
    }

    [HttpPost]
    public async Task<IActionResult> GYerGuncelle(gezilecekYerlerTable model, IFormFile resim)
    {
      if (resim != null)
      {
        var silinecekDosya = Path.Combine(
            Directory.GetCurrentDirectory(),
            @"wwwroot",
            "img",
            model.gYerResim
        );
        System.IO.File.Delete(silinecekDosya);

        string dosyaAdi = Guid.NewGuid() + "_" + resim.FileName;
        string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "img", dosyaAdi);
        using (var stream = new FileStream(path, FileMode.Create))
        {
          await resim.CopyToAsync(stream);
        }
        model.gYerResim = dosyaAdi;
      }
      _gYerRepository.UpdateGYer(model);
      return RedirectToAction("GYerListele");
    }

    public IActionResult GYerSil(int id)
    {
      var kayit = _gYerRepository.GYerGetir(id);
      return View(kayit);
    }

    [HttpPost, ActionName("GYerSil")]
    public IActionResult SilGYer(int id)
    {
      _gYerRepository.DeleteGYer(id);
      return RedirectToAction("GYerListele");
    }
  }

}