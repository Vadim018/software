using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    internal interface ISoftwareBLL
    {
        void CreateLaptop(string companyName, string softwareName);
        bool DeleteLaptop(Software software);
        List<Software> GetAllLaptop();
        Software GetLaptopById(int id);
        bool UpdateLaptop(Software oldItem, string companyName, string softwareName);
    }
}