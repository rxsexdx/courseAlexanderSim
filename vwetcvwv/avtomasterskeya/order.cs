using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomasterskeya
{
    class order : client
    {
        public int ordernumber { get; set; }
        public string detailClient { get; set; }
        public order(int ordernumber, string detailClient, string name, string number, string car, string mail) : base(name, number, car, mail)
        {
            this.ordernumber = ordernumber;
            this.detailClient = detailClient;
            this.name = name;
            this.number = number;
            this.car = car;
            this.mail = mail;
        }
    }
}
