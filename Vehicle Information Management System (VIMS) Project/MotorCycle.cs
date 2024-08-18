using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Information_Management_System__VIMS__Project
{
    public sealed class MotorCycle : TwoWheeler
    {
        public MotorCycle()
        {

        }
        public MotorCycle(string model,int yearMake,int noOfGear,int maxPower,int maxTorque,string cooling,string frontBrake,string rearBrake,int engineCapacityInCC)
        {
            this.ModelNo = model;
            this.YearMake = yearMake;
            this.NoOfGear = noOfGear;
            this.MaxPower = maxPower;
            this.MaxTorque = maxTorque;
            this.Cooling = cooling;
            this.FrontBrake = frontBrake;
            this.RearBrake=rearBrake;
            this.EngineCapacityInCC = engineCapacityInCC;
        }
        public int MaxPower { get; set; }
        public int MaxTorque { get; set; }
        public string Cooling { get; set; }
        public string FrontBrake { get; set; }
        public string RearBrake { get; set; }
    }
}
