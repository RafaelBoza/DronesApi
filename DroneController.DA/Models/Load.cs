using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static DroneController.DA.Models.Enums;

namespace DroneController.DA.Models
{
    public class Load : BaseEntity
    {
        public LoadStates status { get; set; }
        public ICollection<LoadDetail> details { get; set; }

        [ForeignKey(nameof(Drone))]       
        public Drone drone { get; set; }

    }
}
