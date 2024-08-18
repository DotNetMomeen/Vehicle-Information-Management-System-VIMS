using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Information_Management_System__VIMS__Project
{
    public interface IInteriorDesign
    {
        void AddSpecification(string specification);
        string ShowSpecification();
    }
}
