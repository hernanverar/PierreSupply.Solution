using System.Collections.Generic;

namespace PierreSupply.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    public string Name { get; set; }
    // public int Id { get; }
    // public List<Item> Items { get; set; }
  }
}