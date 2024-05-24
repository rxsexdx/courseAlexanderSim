using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomasterskeya
{
    class database
    {
        public string detail { get; set; }
        public bool flag { get; set; }
        public database(string detail, bool flag)
        {
            this.detail = detail;
            this.flag = flag;
        }
    }
}
