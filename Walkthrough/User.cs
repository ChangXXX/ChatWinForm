using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWinForm.Walkthrough
{
    public class User
    {
        public User(string Name, string Pwd)
        {
            this.Name = Name;
            this.Pwd = Pwd;
        }

        public string Name { get; set; }
        public string Pwd { get; set; }

        public string Jwt { get; set; }
    }
}
