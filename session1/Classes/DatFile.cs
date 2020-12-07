using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FirstTask.Classes
{
    class DatFile : AbstractHandler
    {
        public DatFile(string Path) : base(Path)
        {
            path+=Path+".dat";
        }

        private string path;

        public override void Create()
        {
            File.Create(path);
            Console.WriteLine($"Файл успешно создан по пути: {path}");
        }

        public override void Edit()
        {
            Console.WriteLine("Введите предложение, которое хотите добавить");
            string text = Console.ReadLine();
            Save(text);
        }

        public override void Open()
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                //Показываю текст из документа на консоль

                Console.WriteLine(streamReader.ReadToEnd());
            }
        }

        public override void Save(string text)
        {
            string output;
            using (StreamReader streamReader = new StreamReader(path))
            {
                output = streamReader.ReadToEnd();
            }

            output += text;

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(output);
            }
            Console.WriteLine($"Строка: '{text}' успешно добавлена");
        }
    }
}
