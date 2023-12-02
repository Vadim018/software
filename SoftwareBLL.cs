using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    internal class SoftwareBLL : ISoftwareBLL
    {
        IDBItemDAL<Software> dbSoftware;
        public SoftwareBLL(IDBItemDAL<Software> dbSoftware)
        {
            this.dbSoftware = dbSoftware;
        }
        public void CreateLaptop(string companyName, string softwareName)
        {
            Software software = new Software(companyName, softwareName);
            dbSoftware.Add(software);
        }
        public List<Software> GetAllLaptop()
        {
            return dbSoftware.Items.ToList();
        }
        public Software GetLaptopById(int id)
        {
            return dbSoftware.GetById(id);
        }
        public bool DeleteLaptop(Software software)
        {
            return dbSoftware.Delete(software);
        }
        public bool UpdateLaptop(Software oldItem, string companyName, string softwareName)
        {
            Software newItem = new Software(companyName, softwareName);

            if (dbSoftware.Update(oldItem, newItem))
            {
                return true;
            }
            return false;
        }
    }
}