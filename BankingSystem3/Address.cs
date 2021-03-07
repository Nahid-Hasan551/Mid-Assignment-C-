using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem3
{
    class Address
    {
        private int houseNo, roadNo;
        private string city;
        private string country;

        public Address(int houseNo, int roadNo, string city, string country)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.city = city;
            this.country = country;
        }

        public int HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public int RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }
        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }
        public string GetAddress()
        {
            return "Address:House No-"+this.houseNo+", Road No-"+this.roadNo+", City-"+this.city+" ,country-"+this.country;

        }
        public void PrintAddress()
        {
            Console.WriteLine(GetAddress());
        }
    }
}

