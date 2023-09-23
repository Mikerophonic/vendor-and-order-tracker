using System.Collections.Generic;

namespace Tracker.Models
{
    public class Order
    {
      public string Title { get; set; }
      public string Description { get; set; }
      public float Price { get; set; }
      public string Date { get; set; }
      public int Id { get; }
      private static List<Order> _instances = new List<Order> { };



    public Order(string title)
    {
      Title = title;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}