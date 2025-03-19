using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AAPlayground.Models
{
    public class CampFeesModel
    {
        public string ParentName { get; set; }
        public string ChildName { get; set; }
        public int ChildAge { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; } = DateTime.Now;
        public double TotalDue { get; set; }

        public double calcCampFee()
        {
            TimeSpan duration = EndTime.Subtract(StartTime);
            double hours = duration.TotalHours; // explicit casting
            return hours > 4 ? hours * 160 : hours * 100; // Higher rate for more than 4 hours
        }

        public double calcVat()
        {
            return calcCampFee() * 0.15; // Assuming 15% VAT
        }

        public double calcTotalDue()
        {
            return calcCampFee() + calcVat();
        }
    }
}
