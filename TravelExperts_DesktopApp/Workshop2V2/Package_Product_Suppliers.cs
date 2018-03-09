using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author: Rene
* 
*
* 
*/
namespace Workshop2V2
{
    public class Package_Product_Suppliers
    {
        public Package_Product_Suppliers()
        { }

        public int PackageID { get; set; }
        public int ProductSupplierID { get; set; }

        // these objects are for inner join on packages from other tables
        
        public string PkgName { get; set; }
        public string SupName { get; set; }
        public string ProdName { get; set; }
       

    }
}
