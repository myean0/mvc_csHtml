using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _2_03_2023_nevsehir_mvc.Models;
using _2_03_2023_nevsehir_mvc.Services;
using _2_03_2023_nevsehir_mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _2_03_2023_nevsehir_mvc.Controllers
{
  public class HomeController : Controller
  {
    private readonly ISliderTableRepository _sliderRepository;
    private readonly ISehirTableRepository _sehirRepository;
    private readonly IGezilecekYerlerTableRepository _gYerRepository;

    public HomeController(ISliderTableRepository repository, ISehirTableRepository repository1, IGezilecekYerlerTableRepository repository2)
    {
      _sliderRepository = repository;
      _sehirRepository = repository1;
      _gYerRepository = repository2;
    }
    public IActionResult Index()
    {
      SayfaBilgiViewModel sbm = new SayfaBilgiViewModel()
      {
        Sehirler = _sehirRepository.ToList(),
        Sliderlar = _sliderRepository.ToList()
      };
      return View(sbm);
    }

    public IActionResult About()
    {
      SayfaBilgiViewModel sbm = new SayfaBilgiViewModel()
      {
        Sehirler = _sehirRepository.ToList(),
        Sliderlar = _sliderRepository.ToList()
      };
      return View(sbm);
    }

    public IActionResult SayfaHakkinda(int id)
    {
      // var slider = _sliderRepository.ToList();
      var sehir = _sehirRepository.ToList();

      var kayit = _sehirRepository.SehirGetir(id);
      var slider = _sliderRepository.sehirSlider(id);

      SayfaBilgiViewModel viewModel = new()
      {
        Sehirler = sehir,
        Sliderlar = slider,
        sehirTableKayit = kayit
        // sliderTableKayit= kayit2
      };
      return View(viewModel);
    }

    public IActionResult GezilecekYerler(int id)
    {
      var sehir = _sehirRepository.ToList();
      var gYer = _gYerRepository.ToList();

      var kayit = _gYerRepository.GYerGetir(id);

      var detayResim1 = _gYerRepository.DetayResimGetir(id);

      SayfaBilgiViewModel sbm = new()
      {
        Sehirler = sehir,
        GezilecekYerler = gYer,
        gezilecekYerlerKayit = kayit,
        DetayResimler = detayResim1
      };

      return View(sbm);
    }
  }
}