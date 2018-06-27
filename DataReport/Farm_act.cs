using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.DataReport
{
    public class Farm_act
    {
        public string Action_no { get; set; }
        public string Action_name { get; set; }
        public decimal Action_capacity { get; set; }
        public decimal Action_startTime { get; set; }
        public decimal Action_finishTime { get; set; }
        public DateTime Action_datetime { get; set; }        
        public string Drone_id { get; set; }
    }
}
