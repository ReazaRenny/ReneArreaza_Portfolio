using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author: Rene
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*
* 
*/
namespace WebApplication7
{
    public class Customer
    {
    
        public int CustomerID { get; set; }

        public string CustFirstName { get; set; }

        public string CustLastName { get; set; }

        public string CustAddress { get; set; }

        public string CustCity { get; set; }

        public string CustProvince { get; set; }

        public string CustPostal { get; set; }

        public string CustCountry { get; set; }

        public string CustHomePhone { get; set; }

        public string CustBusPhone { get; set; }

        public string CustEmail { get; set; }

        public int AgentID { get; set; }

        public string CustPassword { get; set; }
       
    }
}