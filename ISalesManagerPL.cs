using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    internal interface ISalesManagerPL
    {
        void CreateLaptop();
        void GetAllLaptop();
        void GetLaptopById();
        void DeleteLaptop();
        void UpdateLaptop();
    }
}