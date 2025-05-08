using FiorelloMVC.Contexts;
using FiorelloMVC.Models;
using FiorelloMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVC.Areas.Admin.Controllers;
[Area("Admin")]
public class SliderItems : Controller
{
    private readonly SliderItemService _service;
    public SliderItems()
    {
        _service = new SliderItemService();
    }
    [HttpGet]
    public IActionResult Index()
    {
        List<SliderItem> sliderItems = _service.GetAllSliderItems();
        return View(sliderItems);
    }
    [HttpGet]
    public IActionResult Info(int id) 
    {
        SliderItem sliderItem= _service.GetSliderItemById(id);
        return View(sliderItem);
    
    }
    [HttpGet]
    public IActionResult Create() {
        return View();
    
    
    
    }
    [HttpPost]
    public IActionResult Create(SliderItem sliderItem)
    {
        _service.CreateSliderItem(sliderItem);
        return RedirectToAction(nameof(Index));

    }
    [HttpGet]
    public IActionResult Delete(int id) 
    {
        _service.DeleteSliderItem(id);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        SliderItem sliderItem = _service.GetSliderItemById(id);
        return View(sliderItem);
    }
    [HttpPost]
    public IActionResult Edit(SliderItem sliderItem)
    {
        if (sliderItem.Title == null || sliderItem.Img == null || sliderItem.ShortDescription == null || sliderItem.Price <= 0)
        {
           
            return View(sliderItem);
        }

        _service.UpdateSliderItem(sliderItem);
        return RedirectToAction(nameof(Index));
    }


}
