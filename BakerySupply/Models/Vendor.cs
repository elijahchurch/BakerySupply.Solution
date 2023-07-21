using System.Collections.Generic;

namespace BakerySupply.Models
{
    public class Vendor
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public static int IdCounter {get; set;}
        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            IdCounter += 1;            

        }
    }
}