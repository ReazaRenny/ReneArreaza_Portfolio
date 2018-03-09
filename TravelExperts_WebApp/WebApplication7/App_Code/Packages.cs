using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/* 
* Author: Rene
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*This class is used to store the different information about the customer packages
* 
*/
namespace WebApplication7
{
    public class CustomerPackage
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public int BookingId { get; set; }
        public DateTime? BookingDate { get; set; }
        public int TravelerCount { get; set; }
    }
}