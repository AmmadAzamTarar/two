using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;
namespace Ammad1
{
    [Database]
    public class Home
    {
        int id;
        string city;
        string country;
        string address;
        int zipCode;
        string street;

        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string Address { get => address; set => address = value; }
        public int ZipCode { get => zipCode; set => zipCode = value; }
        public string Street { get => street; set => street = value; }
        //Transaction t;
    }
}
