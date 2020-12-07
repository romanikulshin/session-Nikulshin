using System;
using FirstTask.Classes;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] selection = {"Создать","Открыть","Редактировать"};
            string[] doctype = {"txt","dat"};

            while (true)
            {
                Console.WriteLine(new string('-',30));
                Console.Write("Введите путь к документу: ");
                string path = Console.ReadLine();
                Console.WriteLine(new string('-', 30));


                //Файл формата .txt или .dat
                AbstractHandler file;

                Console.WriteLine("Выберите тип документа");
                for (int i = 0; i < doctype.Length; i++)
                    Console.WriteLine($"{i + 1}.{doctype[i]}");
                Console.Write("---> ");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        file = new TxtFile(path);
                        break;
                    case 2:
                        file = new DatFile(path);
                        break;
                    default:
                        file = null;
                        break;
                }
                Console.WriteLine(new string('-', 30));

                Console.WriteLine("Выберите что сделать с документом");
                for (int i = 0; i < selection.Length; i++)
                    Console.WriteLine($"{i + 1}.{selection[i]}");
                Console.Write("---> ");
                int m = Convert.ToInt32(Console.ReadLine());

                switch (m)
                {
                    case 1:
                        file.Create();
                        break;
                    case 2:
                        file.Open();
                        break;
                    case 3:
                        file.Edit();
                        break;
                }
                Console.WriteLine(new string('-', 30));

                Console.WriteLine("Для продолжения нажмите ENTER, чтобы выйти введите Q");
                Console.Write("--->");
                string exit = Console.ReadLine();
                if (exit == "Q" || exit == "q")
                    break;
            }
        }
    }
}
