using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAPI.Models
{
    public class House
    {
        public int HouseID { get; set; }
        public int HomeOwnerID { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int SquareFootage { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int YearBuilt { get; set; }
        public string Description { get; set; }
        public int ZipCode { get; set; }


        public House()
        {
            
        }

        

        public House(int houseID, int homeownerID, string address, string status, string category, double price, int squareFootage, int bedrooms, int bathrooms, int yearBuilt, string description, int zipcode)
        {
            this.HouseID = houseID;
            this.HomeOwnerID = homeownerID;
            this.Address = address;
            this.Status = status;
            this.Category = category;
            this.Price = price;
            this.SquareFootage = squareFootage;
            this.Bedrooms = bedrooms;
            this.Bathrooms = bathrooms;
            this.YearBuilt = yearBuilt;
            this.Description = description;
            this.ZipCode = zipcode;
        }

        public override String ToString()
        {
            return HomeOwnerID + " " + Address + " " + Status + " " + Category + " " + Price;
        }



    }
}
