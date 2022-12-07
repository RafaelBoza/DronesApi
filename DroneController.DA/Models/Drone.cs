using static DroneController.DA.Models.Enums;

namespace DroneController.DA.Models
{
    public class Drone : BaseEntity
    {
        public string serial_number { get; set; }
        public DroneModels model { get; set; }
        public decimal weight_limit { get; set; }
        public decimal battery_capacity { get; set; }
    }
}
