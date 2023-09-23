using System.Collections.Generic;

namespace Tracker.Models
{
    public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }

    public Order(string title)
    {
        Title = title;
    }

  }
}