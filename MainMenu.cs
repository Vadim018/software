using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    internal class MainMenu : IMenu
    {
        public bool Flag { get; set; }
        StrategyMenu menuStrategy;
        ConsoleColor defaultColor;
        public MainMenu(StrategyMenu menuStrategy)
        {
            this.menuStrategy = menuStrategy;
        }
        public void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("INIT");
        }
        public void Idle()
        {
            Console.WriteLine("1 - SOFTWARE");
            Console.WriteLine("2 - EXIT");

            int menuChoose = int.Parse(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    menuStrategy.Run();
                    break;

                case 2:
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