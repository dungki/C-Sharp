using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Models
{
    class Contact
    {
        private string name;
        private int phone;
        private string address;
        private string job;

        public Contact(string name, int phone, string address, string job)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Job = job;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Phone
        {
            get => phone;
            set => phone = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public string Job
        {
            get => job;
            set => job = value;
        }
    }
}
