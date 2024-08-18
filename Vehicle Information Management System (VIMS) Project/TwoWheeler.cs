using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Information_Management_System__VIMS__Project
{
    public abstract class TwoWheeler : Vehicle, IExteriorDesign
    {
        List<string> spec = new List<string>();
        
        public void AddSpecification(string specification)
        {
            spec.Add(specification);
        }

        public string ShowSpecification()
        {
            return string.Join(", ", spec);
        }
    }
}
