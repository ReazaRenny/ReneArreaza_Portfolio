using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author: Rene
* 
*Initiate objects of the Packages class
* 
*/
namespace Workshop2V2
{
    public class Packages
    {
        public Packages()
        { }
        public int PackageID { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }

       

    }
}
