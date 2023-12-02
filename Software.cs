using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    internal class Software : IID
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string SoftwareName { get; set; }
        public Software(string companyName, string softwareName)
        {
            CompanyName = companyName ;
            SoftwareName = softwareName;
        }
        public override string ToString()
        {
            return String.Format("ID: " + Id + "     " + "COMPANY NAME: " + CompanyName + "     " + "SOFTWARE NAME: " + SoftwareName);
        }
    }
}