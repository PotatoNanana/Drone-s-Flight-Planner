using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.DataReport
{
    public class Drone_part
    {
        public string device_id { get; set; }
        public string device_name { get; set; }
        public int device_position { get; set; }
        public decimal device_price { get; set; }
        public DateTime device_buyDate { get; set; }
        public DateTime device_expDate { get; set; }
        public DateTime device_startDate { get; set; }
        public string device_responder { get; set; }
        public string device_alarm { get; set; }
        public string vender_name { get; set; }
        public string vender_add { get; set; }
        public string vender_phone { get; set; }

    }
}
