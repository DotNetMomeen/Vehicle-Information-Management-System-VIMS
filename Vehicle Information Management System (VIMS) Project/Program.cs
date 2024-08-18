using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Information_Management_System__VIMS__Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int temp = 0;
                while (temp == 0)
                {
                    Console.Write("Which Information do you want?:\n[Hints]\n1. Car\n2. MotorCycle\nEnter Serial No\t:");
                    VehicleType vehicleType = (VehicleType)int.Parse(Console.ReadLine());
                    if (vehicleType == (VehicleType)1 || vehicleType == (VehicleType)2)
                    {
                        if (vehicleType == (VehicleType)1)
                        {
                            CarInfo();
                        }
                        else
                        {
                            MotorCycleInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter a valid No between 1 and 2!!");
                        temp = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please type a valid jinish!!!\n" + ex.Message);
            }
            Console.ReadKey();
        }

        static void CarInfo()
        {
            Console.Write("Model No\t: ");
            string modelNo = Console.ReadLine();

            Console.Write("Year Make\t: ");
            int yearMake = int.Parse(Console.ReadLine());

            Console.Write("Stearing System\t: ");
            string stearinSystem = Console.ReadLine();

            Console.Write("No of seats\t: ");
            int noOfSeats = int.Parse(Console.ReadLine());

            Console.Write("No of doors\t: ");
            int noOfDoors = int.Parse(Console.ReadLine());

            Console.Write("No of gears\t: ");
            int noOfGears = int.Parse(Console.ReadLine());

            Console.Write("Engine capacity in CC\t: ");
            int engineCapacityInCC = int.Parse(Console.ReadLine());

            Car c = new Car(noOfSeats, noOfDoors, stearinSystem, modelNo, yearMake, noOfGears, engineCapacityInCC);

            string specific = "";
            while (specific.ToLower() != "ok")
            {
                Console.Write("Add Interior Design: ");
                specific = Console.ReadLine();
                if (specific.ToLower() != "ok")
                {
                    c.AddSpecification(specific);
                }
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine($"Model No\t\t: {c.ModelNo}");
            Console.WriteLine($"Year Make\t\t: {c.YearMake}");
            Console.WriteLine($"Stearing Syatem\t\t: {c.StearingMethod}");
            Console.WriteLine($"No of Gear\t\t: {c.NoOfGear}");
            Console.WriteLine($"No of Doors\t\t: {c.NoOfDoor}");
            Console.WriteLine($"No of Seats\t\t: {c.NoOfSeat}");
            Console.WriteLine($"Engine capacity in CC\t\t: {c.EngineCapacityInCC}");
            Console.WriteLine($"Interior Design\t\t: {c.ShowSpecification()}");
            Console.WriteLine($"Vehicle Type\t\t: Four Wheeler");
            Console.WriteLine("==========================================");
            Console.WriteLine();

        }
        static void MotorCycleInfo()
        {
            Console.Write("Model No\t: ");
            string modelNo = Console.ReadLine();

            Console.Write("Year Make\t: ");
            int yearMake = int.Parse(Console.ReadLine());

            Console.Write("No of gears\t: ");
            int noOfGears = int.Parse(Console.ReadLine());

            Console.Write("Engine capacity in CC\t: ");
            int engineCapacityInCC = int.Parse(Console.ReadLine());

            Console.Write("Max Power in BHP\t: ");
            int maxPower = int.Parse(Console.ReadLine());

            Console.Write("Max Torque in NM\t: ");
            int maxTorque = int.Parse(Console.ReadLine());

            Console.Write("Cooling System\t: ");
            string coolingSystem = Console.ReadLine();

            Console.Write("Front Brake\t: ");
            string frontBrake = Console.ReadLine();

            Console.Write("Rear Brake\t: ");
            string rearBrake = Console.ReadLine();

            MotorCycle m = new MotorCycle(modelNo, yearMake, noOfGears, maxPower, maxTorque, coolingSystem, frontBrake, rearBrake, engineCapacityInCC);


            string specific = "";
            while (specific.ToLower() != "ok")
            {
                Console.Write("Add Exterior Design: ");
                specific = Console.ReadLine();
                if (specific.ToLower() != "ok")
                {
                    m.AddSpecification(specific);
                }
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine($"Model No\t\t: {m.ModelNo}");
            Console.WriteLine($"Year Make\t\t: {m.YearMake}");
            Console.WriteLine($"No of Gear\t\t: {m.NoOfGear}");
            Console.WriteLine($"Engine capacity in CC\t\t: {m.EngineCapacityInCC}");
            Console.WriteLine($"Interior Design\t\t: {m.ShowSpecification()}");
            Console.WriteLine($"Vehicle Type\t\t: Two Wheeler");
            Console.WriteLine("==========================================");
            Console.WriteLine();
        }
    }
}
