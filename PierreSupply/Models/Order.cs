using System.Collections.Generic;
using System;


namespace PierreSupply.Models
{
  public class Order
  {
    public string Product { get; set;}
    public int Id { get; }
    public string Title { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public Order(string title, string produce)
    {
      Title= title;
      Product = produce;
      _instances.Add(this);
      Id = _instances.Count;
    }
      public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}