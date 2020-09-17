using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Models
{
    class ProductItem
    {
        char icon;
        string name;
        string dest;

        public ProductItem(char icon, string name, string dest)
        {
            Icon = icon;
            Name = name;
            Dest = dest;
        }

        public string Dest
        {
            get => dest;
            set => dest = value;
        }

        public char Icon
        {
            get => icon;
            set => icon = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
