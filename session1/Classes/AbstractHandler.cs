using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTask.Classes
{
    abstract class AbstractHandler
    {
        public AbstractHandler(string Path)
        {
            this.Path = Path;
        }

        public string Path { get; set; }

        abstract public void Edit();
        abstract public void Open();
        abstract public void Save(string text);
        abstract public void Create();
    }
}
