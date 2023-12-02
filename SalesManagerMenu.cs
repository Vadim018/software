using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    internal class SalesManagerMenu : IMenu
    {
        public bool Flag { get; set; }
        ISalesManagerPL salesManagerPL;
        ConsoleColor defaultColor;
        public SalesManagerMenu(ISalesManagerPL salesManagerPL)
        {
            this.salesManagerPL = salesManagerPL;
        }
        public void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("INIT");
        }
        public void Idle()
        {
            Console.WriteLine("1. CREATE");
            Console.WriteLine("2. GET");
            Console.WriteLine("3. FIND BY ID");
            Console.WriteLine("4. DELETE");
            Console.WriteLine("5. UPDATE");
            Console.WriteLine("6. EXIT");

            int menuChoose = int.Parse(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    salesManagerPL.CreateLaptop();
                    break;
                case 2:
                    salesManagerPL.GetAllLaptop();
                    break;
                case 3:
                    salesManagerPL.GetLaptopById();
                    break;
                case 4:
                    salesManagerPL.DeleteLaptop();
                    break;
                case 5:
                    salesManagerPL.UpdateLaptop();
                    break;
                case 6:
                    Flag = false;
                    break;
                default:
                    Console.WriteLine("ERROR! PLEASE, TRY AGAIN...");
                    break;
            }
        }
        public void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
            Console.WriteLine("CLEANUP");
        }
    }
}