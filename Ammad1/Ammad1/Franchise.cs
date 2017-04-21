using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace Ammad1
{
    [Database]
    public class Franchise
    {
        int id;
        string name;
        string street;
        int number;
        string zipCode;
        string city;
        string country;
        string address;
        Corporation corp;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public int Number { get => number; set => number = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string Address { get => address; set => address = value; }
        public Corporation Corp { get => corp; set => corp = value; }
        
    }
}
