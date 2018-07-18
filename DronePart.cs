using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner
{
    public class DronePart
    {
        public string Device_id { get; set; }
        public string Device_name { get; set; }
        public int Device_position { get; set; }
        public decimal Device_price { get; set; }
        public DateTime Device_buyDate { get; set; }
        public DateTime Device_expDate { get; set; }
        public DateTime Device_startDate { get; set; }
        public string Dvice_responder { get; set; }
        public string Device_alarm { get; set; }
        public string Vender_name { get; set; }
        public string Vender_add { get; set; }
        public string Vender_phone { get; set; }
        public string Drone_id { get; set; }
    }
}
