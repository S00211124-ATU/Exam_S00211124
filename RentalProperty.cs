using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_S00211124
{
    public class RentalProperty
    {
        // properties
        public int ID { get; set; }
        public enum RentalType
        {
            House,
            Flat,
            Share
        }
        public string Location { get; set; }

        public decimal Price { get; set; }
        public string Description { get; set; }
        public RentalType TypeOfRental { get; set; }

        public void IncreaseRentPercentage(decimal percentageDecrease)
        {
            Price = Price - (Price * (percentageDecrease/100));
        }

    } //end of class

    public class RentalData:DbContext
    {
        public RentalData() : base("MyRentalData") { }
        public DbSet<RentalProperty> Properties { get; set; }
    }
}
