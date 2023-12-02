/*
--------------------------------------------------------------------------------------------------------------------
Завдання S10
--------------------------------------------------------------------------------------------------------------------
Створити в окремому класі DBItemDAL колекцію об'єктів класу Software та вивести інформацію щодо колекції на консоль.
Клас повинен мати такі властивості (поля): 
'Id' 'CompanyName' 'SoftwareName'
Окремий клас DBItemDAL повинен мати інтерфейс та такі методи:
 * додавання елемента до колекції;
 * отримання всіх елементів з колекції;
 * пошук елемента по Id;
 * видалення елемента з колекції;
 * заміна старого елемента на новий.
Створити окремий клас SoftwareBLL з інтерфейсом, методи якого використовують методи класу з колекцією.
Створити окремий клас SalesManagerPL з інтерфейсом, методи якого використовують методи класу SoftwareBLL.
Створити дворівневе меню використовуючи патерн проектування Стратегія та універсальний алгоритм. MainMenu та SalesManagerMenu. 
Кожне меню в окремому класі.
------------------------------------------------------------------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IDBItemDAL<Software> dbSoftware = new DBItemDAL<Software>();

            Software software1 = new Software("MICROSOFT", "OFFICE");
            dbSoftware.Add(software1);

            Software software2 = new Software("MICROSOFT", "TEAMS");
            dbSoftware.Add(software2);

            Software software3 = new Software("MICROSOFT", "STORE");
            dbSoftware.Add(software3);

            ISoftwareBLL softwareBLL = new SoftwareBLL(dbSoftware);
            
            ISalesManagerPL salesManagerPL = new SalesManagerPL(softwareBLL);

            SalesManagerMenu salesManagerMenu = new SalesManagerMenu(salesManagerPL);

            StrategyMenu menuStrategySalesManager = new StrategyMenu(salesManagerMenu);

            MainMenu mainMenu = new MainMenu(menuStrategySalesManager);

            StrategyMenu menuStrategyMain = new StrategyMenu(mainMenu);

            menuStrategyMain.Run();

            Console.ReadLine();
        }
    }
}