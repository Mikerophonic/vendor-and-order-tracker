using System.Collections.Generic;

namespace Tracker.Models
{
    public class Vendor
  {
    public string Name { get; set; }
    public string Address { get; set; }

    public Vendor(string name, string address)
    {
        Name = name;
        Address = address;
    }
  }
}

