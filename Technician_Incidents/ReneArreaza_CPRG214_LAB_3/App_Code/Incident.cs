using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReneArreaza_CPRG214_LAB_3.App_Code
{
    public class Incident
    {
        public int IncidentID { get; set; }
        public int CustomerID { get; set; }
        public int TechID { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

    }
}