using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    //  Модель компьютера  характеризуется кодом  и названием  марки компьютера, типом  процессора,
    //  частотой работы  процессора,  объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты,
    //  стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии.Создать список,
    //  содержащий 6-10 записей с различным набором значений характеристик.

    // Определить:
    // - все компьютеры с указанным процессором.Название процессора запросить у пользователя;+
    // - все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;+
    // - вывести весь список, отсортированный по увеличению стоимости;+
    // - вывести весь список, сгруппированный по типу процессора;+
    // - найти самый дорогой и самый бюджетный компьютер;+
    // - есть ли хотя бы один компьютер в количестве не менее 30 штук?


    class Program
    {
        static void Main(string[] args)
        {
            List<Model> model = new List<Model>()
            {
                new Model(){Code = 1, Name = "Apple", CPU_Type = "M1",  CPU_frequency = 5000, RAM =64, Hard_disk = 1024,  Graphics_card = 1024, Price = 2100, Stock = 10},
                new Model(){Code = 2, Name = "Lenovo", CPU_Type = "Intel",  CPU_frequency = 3500, RAM =32, Hard_disk = 512,  Graphics_card = 1024, Price = 1000, Stock = 40},
                new Model(){Code = 3, Name = "MSI", CPU_Type = "AMD",  CPU_frequency = 4000, RAM =24, Hard_disk = 1024,  Graphics_card = 1024, Price = 1100, Stock = 50},
                new Model(){Code = 4, Name = "Acer", CPU_Type = "Intel",  CPU_frequency = 3000, RAM =24, Hard_disk = 512,  Graphics_card = 512, Price = 1950, Stock = 29},
                new Model(){Code = 5, Name = "HP", CPU_Type = "Intel",  CPU_frequency = 4000, RAM =32, Hard_disk = 512,  Graphics_card = 1024, Price = 1700, Stock = 40},
                new Model(){Code = 6, Name = "DELL", CPU_Type = "Intel",  CPU_frequency = 3000, RAM =32, Hard_disk = 1024,  Graphics_card = 512, Price = 2000, Stock = 31},
                new Model(){Code = 3, Name = "MSI", CPU_Type = "AMD",  CPU_frequency = 4100, RAM =128, Hard_disk = 512,  Graphics_card = 1024, Price = 1500, Stock = 50},

            };
            Console.WriteLine("Введите название процессора:");
            string cpu = Console.ReadLine();
            List<Model> model1 = model.Where(x => x.CPU_Type == cpu).ToList();
            Print(model1);

            Console.WriteLine("Введите название процессора:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Model> model2 = model.Where(x => x.RAM >= ram).ToList();
            Print(model2);

            List<Model> model3 = model.OrderBy(x => x.Price).ToList();
            Print(model3);

            IEnumerable<IGrouping<string, Model>> model4 = model.GroupBy(x => x.CPU_Type);
            foreach (IGrouping<string, Model> i in model4)
            {
                Console.WriteLine(i.Key);
                foreach (Model x in i)
                {
                    Console.WriteLine($"{x.Code} - {x.Name}, {x.CPU_Type}, {x.CPU_frequency}, {x.RAM}, {x.Hard_disk}, {x.Graphics_card}, {x.Price}, {x.Stock}");
                }
            }

            Model model5 = model.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{model5.Code} - {model5.Name}, {model5.CPU_Type}, {model5.CPU_frequency}, {model5.RAM}, {model5.Hard_disk}, {model5.Graphics_card}, {model5.Price}, {model5.Stock}");

            Model model6 = model.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{model6.Code} - {model6.Name}, {model6.CPU_Type}, {model6.CPU_frequency}, {model6.RAM}, {model6.Hard_disk}, {model6.Graphics_card}, {model6.Price}, {model6.Stock}");

            Console.WriteLine(model.Any(x => x.Stock >= 30));

            Console.ReadKey();
        }
        static void Print(List<Model> model)
        {
            foreach (Model x in model)
            {
                Console.WriteLine($"{x.Code} - {x.Name}, {x.CPU_Type}, {x.CPU_frequency}, {x.RAM}, {x.Hard_disk}, {x.Graphics_card}, {x.Price}, {x.Stock}");
            }
            Console.WriteLine();
        }
    }
}
