using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomasterskeya
{
    class client
    {
        public string name { get; set; }
        public string number { get; set; }
        public string car { get; set; }
        public string mail { get; set; }
        public client(string name, string number, string car, string mail)
        {
            this.name = name;
            this.number = number;
            this.car = car;
            this.mail = mail;
        }
    }
}
