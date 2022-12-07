namespace DroneController.DA.Models
{
    public class Medication : BaseEntity
    {
        public string name { get; set; }
        public decimal weight { get; set; }
        public string code { get; set; }
        public string image { get; set; }
    }
}
