using System.Collections.Generic;

namespace BakerySupply.Models
{
    public class Order
    {
        public string Name {get; set;}
        public string Description {get; set;}

        public Order(string name, string description, int price, string date)
        {
            Name = name;
            Description = description;

        }
    }
}