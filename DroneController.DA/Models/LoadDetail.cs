using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DroneController.DA.Models
{
    public class LoadDetail:BaseEntity
    {
        [ForeignKey(nameof(Medication))]
        public Medication medication { get; set; } 

        [ForeignKey(nameof(Load))]
        public Load load { get; set; }
       
    }
}
