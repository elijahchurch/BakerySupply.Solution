using System.Collections.Generic;

namespace BakerySupply.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static int IdCounter { get; set; }
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
        public static List<Vendor> _vendorList = new List<Vendor> { };
        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            IdCounter += 1;
            Id = IdCounter;
            Orders = new List<Order> { };
            _vendorList.Add(this);
        }

        public void AddOrder(Order newOrder)
        {
            Orders.Add(newOrder);
        }

        public static Vendor FindVendor(int searchId)
        {
            return _vendorList.Find(x=> x.Id == searchId);
        }

        public static List<Vendor> GetAll()
        {
            return _vendorList;
        }

        public static void ClearAll()
        {
            _vendorList.Clear();
        }

        public static void Delete(Vendor foundVendor)
        {
            _vendorList.Remove(foundVendor);
        }
    }
}