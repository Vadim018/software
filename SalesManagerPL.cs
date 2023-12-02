using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    class SalesManagerPL : ISalesManagerPL
    {
        ISoftwareBLL softwareBLL;
        public SalesManagerPL(ISoftwareBLL softwareBLL)
        {
            this.softwareBLL = softwareBLL;
        }
        public void CreateLaptop()
        {
            Console.Write("COMPANY NAME: ");
            string companyName = Console.ReadLine();

            Console.Write("SOFTWARE NAME: ");
            string softwareName = Console.ReadLine();

            softwareBLL.CreateLaptop(companyName, softwareName);
        }
        public void GetAllLaptop()
        {
            List<Software> softwareList = softwareBLL.GetAllLaptop();
            foreach (Software s in softwareList)
            {
                Console.WriteLine(s);
            }
        }
        public void GetLaptopById()
        {
            Console.Write("ENTER ID SOFTWARE: ");
            int id = int.Parse(Console.ReadLine());

            Software software = softwareBLL.GetLaptopById(id);

            if (software != null)
            {
                Console.WriteLine(software);
            }
            else
            {
                Console.WriteLine("SOFTWARE DON'T FOUND :(");
            }
        }
        public void DeleteLaptop()
        {
            List<Software> softwareList = softwareBLL.GetAllLaptop();

            foreach (Software s in softwareList)
            {
                Console.WriteLine(s);
            }
            Console.Write("ENTER ID SOFTWARE: ");
            int softwareId = int.Parse(Console.ReadLine());

            Software foundSoftware = softwareList.FirstOrDefault(d => d.Id == softwareId);

            if (foundSoftware == null)
            {
                Console.WriteLine("SOFTWARE DON'T FOUND :(");
                return;
            }

            bool isDeleted = softwareBLL.DeleteLaptop(foundSoftware);

            if (isDeleted)
            {
                Console.WriteLine("SOFTWARE SUCCESSFULLY DELETED :)");
            }
            else
            {
                Console.WriteLine("SOFTWARE DON'T FOUND :(");
            }
        }
        public void UpdateLaptop()
        {
            Console.Write("ENTER ID SOFTWARE: ");
            int softwareId = int.Parse(Console.ReadLine());

            Software software = softwareBLL.GetLaptopById(softwareId);

            if (software != null)
            {
                Console.WriteLine("DO YOU WANT TO UPDATE THIS SOFTWARE?");
                Console.WriteLine("1. YES");
                Console.WriteLine("2. NO");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("ENTER COMPANY NAME: ");
                        string companyName = Console.ReadLine();

                        Console.Write("ENTER SOFTWARE NAME: ");
                        string softwareName = Console.ReadLine();

                        if (softwareBLL.UpdateLaptop(software, companyName, softwareName))
                        {
                            Console.WriteLine("SOFTWARE SUCCESSFULLY UPDATED :)");
                        }
                        else
                        {
                            Console.WriteLine("SOFTWARE UPDATE FAILED :(");
                        }
                        break;
                    case 2:
                        Console.WriteLine("GOOD LUCK :)");
                        break;
                }
            }
        }
    }
}