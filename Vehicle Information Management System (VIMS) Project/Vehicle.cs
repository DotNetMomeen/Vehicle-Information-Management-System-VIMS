using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Information_Management_System__VIMS__Project
{
    public abstract class Vehicle
    {
        public string ModelNo { get; set; }
        public int YearMake { get; set; }
        public int NoOfGear { get; set; }
        public int EngineCapacityInCC { get; set; }
    }
}
