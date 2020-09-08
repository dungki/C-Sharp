using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1907Sem3.Models
{
    class Email
    {
        public string email { get; set; }
        public string title {get; set;}
        public string content { get; set; }

        public Email(string email, string eitle, string content)
        {
            this.email = email;
            this.title = title;
            this.content = content;
        }

        public override string ToString()
        {
            return "Enail: " + email + "\n"
                + "Title: " + title + "\n"
                + "Content: " + content + "\n";
        }
    }
}
