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
        public DateTime EndTime { get; set; }
        public double TotalDue { get; set; }

        public double calcCampFee()
        {
            TimeSpan duration = EndTime.Subtract(StartTime);
            double hours = duration.TotalHours; //explicit casting
            if (hours > 4)
            {
                return hours * 160; // Higher rate for more than 4 hours
            }
            else
            {
                return hours * 100; // Standard rate
            }
        }

        public double calcVat()
        {
            double fee = calcCampFee();
            return fee * 0.15; // Assuming 15% VAT
        }

        public double calcTotalDue()
        {
            double fee = calcCampFee();
            double vat = calcVat();
            return fee + vat;
        }

    }
}