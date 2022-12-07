using System;
using System.Collections.Generic;
using System.Text;

namespace DroneController.DA.Models
{
    public class Enums
    {
        public enum States { IDLE =1, LOADING=2, LOADED=3, DELIVERING=4, DELIVERED=5, RETURNING=6 }
        public enum LoadStates {CREATED=1, LOADED=2, DELIVERING=3, DELIVERED=4}
        public enum DroneModels { Lightweight = 1, Middleweight = 2, Cruiserweight = 3, Heavyweight = 4 }
    }
   
    
}
