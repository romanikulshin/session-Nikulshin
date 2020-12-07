using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LB6_2.Classes
{
    public class PlayerItem
    {
        public PlayerItem(string Url,string Name,string Type)
        {
            this.Url = Url;
            this.Type = Type;
            this.Name = Name;
        }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
