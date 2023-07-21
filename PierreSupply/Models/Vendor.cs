using System.Collections.Generic;

namespace PierreSupply.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Product { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
  }
  public Vendor(string vendorName, string vendorProduct)

  {
    Name = vendorName;
    Product = vendorProduct;
    _instances.Add(this);
    Id = _instances.Count;
    Orders = new List<Order> { };
  }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
}