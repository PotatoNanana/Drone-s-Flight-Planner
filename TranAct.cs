using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner
{
    public class TranAct
    {
        public DateTime Transaction_datetime { get; set; }
        public string Farm_id { get; set; }
        public string Farm_name { get; set; }
        public string Farm_host { get; set; }
        public string Farm_address { get; set; }
        public string Farm_road { get; set; }
        public string Farm_subDistrict { get; set; }
        public string Farm_district { get; set; }
        public string Farm_province { get; set; }
        public string Farm_postal { get; set; }
        public string Drone_id { get; set; }
        public string Drone_name { get; set; }
        public string Action_no { get; set; }
        public string Action_name { get; set; }
        public string Material_name { get; set; }
        public string Action_capacity { get; set; }
        public string Action_cost { get; set; }
        public string Distance { get; set; }
        public string Area { get; set; }
       
       // public string  { get; set; }
    }
}
