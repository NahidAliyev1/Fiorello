using System.Drawing;
using FiorelloMVC.Contexts;
using FiorelloMVC.Models;

namespace FiorelloMVC.Services;

public class SliderItemService
{
    private readonly AppDbContext _context;


    public SliderItemService()
    {
        _context = new AppDbContext();
    }
    #region Create
    public void CreateSliderItem(SliderItem sliderItem) {

        _context.SliderItems.Add(sliderItem);
        _context.SaveChanges();
    }

    #endregion
    #region Read

    public SliderItem GetSliderItemById(int id) {

        SliderItem? sliderItem = _context.SliderItems.Find(id);
        if (sliderItem is null)
        {
            throw new Exception($"Database daxilinde {id} id-e sahib bir data tapilmadi");    
        }
        return sliderItem;
    }

    public List<SliderItem> GetAllSliderItems() {
        List<SliderItem> slidersItems = _context.SliderItems.ToList();


        return slidersItems;
    }

    #endregion

    #region Update

    public void UpdateSliderItem(SliderItem updatedSliderItem)
    {
        SliderItem? sliderItem = _context.SliderItems.Find(updatedSliderItem.Id);
        if (sliderItem is null)
        {
            throw new Exception($"Database daxilində {updatedSliderItem.Id} id-li SliderItem tapılmadı.");
        }

        sliderItem.Title = updatedSliderItem.Title;
        sliderItem.Price = updatedSliderItem.Price;
        sliderItem.ShortDescription = updatedSliderItem.ShortDescription;
        sliderItem.ShortDescription = updatedSliderItem.ShortDescription;
        sliderItem.Img = updatedSliderItem.Img;

        _context.SaveChanges();
    }

    #endregion


    #region Delete
    public void DeleteSliderItem(int id) 
    {

        SliderItem? sliderItem = _context.SliderItems.Find(id);
        if (sliderItem is null)
        {
            throw new Exception($"Database daxilinde {id} id-e sahib bir data tapilmadi");
        }
        _context.SliderItems.Remove(sliderItem);
        _context.SaveChanges();
    }
    #endregion
}
