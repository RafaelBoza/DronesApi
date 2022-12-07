using System;
using System.Collections.Generic;
using System.Text;
using static DroneController.DA.Models.Enums;

namespace DroneController.DL.Models
{
    public class DroneModel : BaseModel
    {
        public string serial_number { get; set; }
        public DroneModels model { get; set; }
        public decimal weight_limit { get; set; }
        public decimal battery_capacity { get; set; }
    }
}
