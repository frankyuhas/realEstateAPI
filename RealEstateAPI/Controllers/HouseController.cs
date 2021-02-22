using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Utilities;
using RealEstateAPI.Models;
using System.Data;

namespace RealEstateAPI.Controllers
{
    [Route("WebAPI/Service/[controller]")]
    
    public class HouseController : Controller //Default Route: WebAPI/Service/House
    {
        [HttpGet("GetAllHouses")] //route: WebAPI/Service/House   //has been configured with ajax
        public List<House> GetAllHouses()
        {
            DBConnect db = new DBConnect();

            String sql = "SELECT * FROM Houses";
            DataSet recordSet = db.GetDataSet(sql);
            List<House> houseList = new List<House>();
            House house;

            for (int row = 0; row < recordSet.Tables[0].Rows.Count; row++)
            {
                house = new House();
                DataRow record = recordSet.Tables[0].Rows[row];

                house.HouseID = int.Parse(record["HouseID"].ToString());
                house.HomeOwnerID = int.Parse(record["HomeOwnerID"].ToString());
                house.Address = record["Address"].ToString();
                house.Status = record["Status"].ToString();
                house.Category = record["Category"].ToString();
                house.Price = double.Parse(record["Price"].ToString());
                house.SquareFootage = int.Parse(record["SquareFootage"].ToString());
                house.Bedrooms = int.Parse(record["Bedrooms"].ToString());
                house.Bathrooms = int.Parse(record["Bathrooms"].ToString());
                house.YearBuilt = int.Parse(record["YearBuilt"].ToString());
                house.Description = record["Description"].ToString();
                house.ZipCode = int.Parse(record["ZipCode"].ToString());
                houseList.Add(house);
            }

            return houseList;
        }

        [HttpGet("GetHouseByID/{HouseID}")]  //route: WebAPI/Sevice/House/GetHouse/123   //has been configured with ajax
        public House GetHouseByID(int HouseID)
        {
            DBConnect db = new DBConnect();
            

            String sql = "SELECT * FROM Houses WHERE HouseID = " + HouseID;
            DataSet recordSet = db.GetDataSet(sql);
            House house = new House();

            //check if record was returned
            if (recordSet.Tables[0].Rows.Count > 0)
            {
                DataRow record = recordSet.Tables[0].Rows[0];

                house.HouseID = int.Parse(record["HouseID"].ToString());
                house.HomeOwnerID = int.Parse(record["HomeOwnerID"].ToString());
                house.Address = record["Address"].ToString();
                house.Status = record["Status"].ToString();
                house.Category = record["Category"].ToString();
                house.Price = double.Parse(record["Price"].ToString());
                house.SquareFootage = int.Parse(record["SquareFootage"].ToString());
                house.Bedrooms = int.Parse(record["Bedrooms"].ToString());
                house.Bathrooms = int.Parse(record["Bathrooms"].ToString());
                house.YearBuilt = int.Parse(record["YearBuilt"].ToString());
                house.Description = record["Description"].ToString();
                house.ZipCode = int.Parse(record["ZipCode"].ToString());
            }
           
            

            

            return house;
        }

        [HttpGet("GetHousesByZip/{zipcode}")]  //route: WebAPI/Sevice/House/GetHousesByZip/19999
        public List<House> GetHousesByZip(int ZipCode)
        {
            DBConnect db = new DBConnect();


            String sql = "SELECT * FROM Houses WHERE ZipCode = " + ZipCode;
            DataSet recordSet = db.GetDataSet(sql);
            List<House> houseList = new List<House>();
            

            //check if record was returned
            for(int row = 0; row < recordSet.Tables[0].Rows.Count; row++)
            {
                House house = new House();
                DataRow record = recordSet.Tables[0].Rows[row];

                house.HouseID = int.Parse(record["HouseID"].ToString());
                house.HomeOwnerID = int.Parse(record["HomeOwnerID"].ToString());
                house.Address = record["Address"].ToString();
                house.Status = record["Status"].ToString();
                house.Category = record["Category"].ToString();
                house.Price = double.Parse(record["Price"].ToString());
                house.SquareFootage = int.Parse(record["SquareFootage"].ToString());
                house.Bedrooms = int.Parse(record["Bedrooms"].ToString());
                house.Bathrooms = int.Parse(record["Bathrooms"].ToString());
                house.YearBuilt = int.Parse(record["YearBuilt"].ToString());
                house.Description = record["Description"].ToString();
                house.ZipCode = int.Parse(record["ZipCode"].ToString());
                houseList.Add(house);
            }





            return houseList;
        }


        [HttpGet("GetHousesByCategory/{category}")]  //route: WebAPI/Sevice/House/GetHousesByCategory/Single
        public List<House> GetHousesByCategory(string Category)
        {
            DBConnect db = new DBConnect();


            String sql = "SELECT * FROM Houses WHERE Category = '" + Category + "' ";
            DataSet recordSet = db.GetDataSet(sql);
            List<House> houseList = new List<House>();


            //check if record was returned
            for (int row = 0; row < recordSet.Tables[0].Rows.Count; row++)
            {
                House house = new House();
                DataRow record = recordSet.Tables[0].Rows[row];

                house.HouseID = int.Parse(record["HouseID"].ToString());
                house.HomeOwnerID = int.Parse(record["HomeOwnerID"].ToString());
                house.Address = record["Address"].ToString();
                house.Status = record["Status"].ToString();
                house.Category = record["Category"].ToString();
                house.Price = double.Parse(record["Price"].ToString());
                house.SquareFootage = int.Parse(record["SquareFootage"].ToString());
                house.Bedrooms = int.Parse(record["Bedrooms"].ToString());
                house.Bathrooms = int.Parse(record["Bathrooms"].ToString());
                house.YearBuilt = int.Parse(record["YearBuilt"].ToString());
                house.Description = record["Description"].ToString();
                house.ZipCode = int.Parse(record["ZipCode"].ToString());
                houseList.Add(house);
            }





            return houseList;
        }


        [HttpGet("GetHousesByCriteria/{criteria}/{num}")]  //route: WebAPI/Sevice/House/SearchHouse/sqft/2500
        public List<House> GetHousesByCriteria(string criteria, int num)
        {
            DBConnect db = new DBConnect();


            String sql = "SELECT * FROM Houses WHERE " + criteria + " = " + num;
            DataSet recordSet = db.GetDataSet(sql);
            List<House> houseList = new List<House>();


            //check if record was returned
            for (int row = 0; row < recordSet.Tables[0].Rows.Count; row++)
            {
                House house = new House();
                DataRow record = recordSet.Tables[0].Rows[row];

                house.HouseID = int.Parse(record["HouseID"].ToString());
                house.HomeOwnerID = int.Parse(record["HomeOwnerID"].ToString());
                house.Address = record["Address"].ToString();
                house.Status = record["Status"].ToString();
                house.Category = record["Category"].ToString();
                house.Price = double.Parse(record["Price"].ToString());
                house.SquareFootage = int.Parse(record["SquareFootage"].ToString());
                house.Bedrooms = int.Parse(record["Bedrooms"].ToString());
                house.Bathrooms = int.Parse(record["Bathrooms"].ToString());
                house.YearBuilt = int.Parse(record["YearBuilt"].ToString());
                house.Description = record["Description"].ToString();
                house.ZipCode = int.Parse(record["ZipCode"].ToString());
                houseList.Add(house);
            }





            return houseList;

            
        }

        [HttpPut("UpdateHouse/{houseID}")]
        public Boolean Put(int houseID, [FromBody]House theHouse)
        {
            DBConnect db = new DBConnect();

            String sql = "UPDATE Houses SET Status = '" + theHouse.Status + "', Price = " + theHouse.Price +
                         " WHERE HouseID =" + houseID;


            int result = db.DoUpdate(sql);

            if (result > 0)
                return true;


            return false;
        }

        //[HttpDelete("DeleteHouse/{houseID}")]
        //public void DeleteHouse(int houseID)
        //{
        //    DBConnect db = new DBConnect();

        //    String sql = "DELETE FROM Houses WHERE HouseID =" + houseID;


        //}


        


        [HttpPost("SaveHouse")]   //route: WebAPI/Sevice/House/SaveHouse
        public Boolean PostHouse([FromBody]House theHouse)
        {
            DBConnect db = new DBConnect();
            string strSQL = "INSERT INTO Houses (NULL, NULL, Address, Status, Category, Price, SquareFootage, Bedrooms, Bathrooms, YearBuilt, Description, ZipCode) " +
                "VALUES ('" + theHouse.Address + "', '" + theHouse.Status + "', '" + theHouse.Category + "', " + theHouse.Price + ", " + theHouse.SquareFootage + ", " + theHouse.Bedrooms + ", " + theHouse.Bathrooms + ", " + theHouse.YearBuilt + ", '" + theHouse.Description + "', " + theHouse.ZipCode + ")";

            int result = db.DoUpdate(strSQL);

            if(result > 0)
            {
                return true;
            }

            return false;
        }

        



    }
}