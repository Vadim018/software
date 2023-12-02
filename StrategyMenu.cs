using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    internal class StrategyMenu
    {
        IMenu menu;
        public StrategyMenu(IMenu menu)
        {
            this.menu = menu;
        }
        public void Run()
        {
            menu.Init();
            while (menu.Flag == true)
            {
                menu.Idle();
            }
            menu.CleanUp();
        }
    }
}