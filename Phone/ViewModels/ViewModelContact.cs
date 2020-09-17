using Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.ViewModels
{
    class ViewModelContact
    {
        public static List<Contact> ContactList = new List<Contact>();

        public ViewModelContact()
        {
            if (ContactList.Count == 0)
            {
                ContactList.Add(new Models.Contact("Trần Mạnh Dũng", 0999666999, "Hà Nội", "Dev"));
                ContactList.Add(new Models.Contact("Nguyễn Hồng Huy",0987654321, "Phú Thọ", "Designer"));

            }

        }
        public List<Contact> Contacts
        {
            get => ContactList;
        }
    }
}
