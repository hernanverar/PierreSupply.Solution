using System.Collections.Generic;

namespace PierreSupply.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    // public int Id { get; }
    // public List<Item> Items { get; set; }
  }
}