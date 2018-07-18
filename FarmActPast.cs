using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner
{
    class FarmActPast
    {
        
        public string action_no { get; set; }
        public string farm_id { get; set; }
        public string drone_id { get; set; }
        public decimal action_capacity { get; set; }
        public decimal action_cost { get; set; }
        public DateTime action_datetime { get; set; }
        public string action_startTime { get; set; }
        public string action_finishTime { get; set; }
        public string act_no { get; set; }
        public string action_name { get; set; }
        public string material_no { get; set; }
        public string material_name { get; set; }        
    }
}
