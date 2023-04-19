using System;
using System.Linq;
using Xunit;
using Casestudymini;
namespace Testproject
{
    public class UnitTest1
    {
        FoodEntities ob = new FoodEntities();
        //foodEntities ob = new foodEntities();
        [Fact]
        public void TestMethod1()
        {
         

            Restaurant a = new Restaurant();
            a.Restaurantid = 110;
            a.Restaurantname = "seaview";
            a.Rcity = "Mangalore";
            a.Rlocation = "Shiv nagar";
            a.Details = "VEG";
            a.Branch = "mangalore_5";

            //insertion
            ob.Restaurants.Add(a);
            int rowsAffeectedd = ob.SaveChanges();// no of rows affected
            //assert
            Assert.True(rowsAffeectedd > 0 ? true : false);





            Fooditem c = new Fooditem();
            Userpassword o = new Userpassword();
            Orderfood d = new Orderfood();
            Orderstatu e = new Orderstatu();



        }
    }
}




























