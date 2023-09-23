using System.Collections.Generic;

namespace Tracker.Models
{
    public class Vendor
  {
    public string Name { get; set; }
    public string Address { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };


    public Vendor(string name, string address)
    {
        Name = name;
        Address = address;
        _instances.Add(this);

    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

