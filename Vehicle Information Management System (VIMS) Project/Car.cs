using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Information_Management_System__VIMS__Project
{
    public sealed class Car : FourWheeler
    {
        public Car()
        {
            
        }
        public Car(int noOfSeat, int noOfDoor, string stearingMethod,string model,int yearMake,int noOfGear,int engineCapacity)
        {
            NoOfSeat = noOfSeat;
            NoOfDoor = noOfDoor;
            StearingMethod = stearingMethod;
            ModelNo = model;
            YearMake = yearMake;
            NoOfGear = noOfGear;
            EngineCapacityInCC = engineCapacity;
        }

        public int NoOfSeat { get; set; }
        public int NoOfDoor { get; set; }
        public string StearingMethod { get; set; }

    }
}
