using System.Collections.Generic;

namespace BakerySupply.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date {get; set;}
        public static int IdCounter {get; set;}
        public int Id {get;set;}

        public Order(string name, string description, int price, string date)
        {
            Name = name;
            Description = description;
            Price = price;
            Date = date;
            IdCounter +=1;
            Id = IdCounter;
        }
    }
}