using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Model
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string CPU_Type { get; set; }
        public int CPU_frequency { get; set; }
        public int RAM { get; set; }
        public int Hard_disk { get; set; }
        public int Graphics_card { get; set; }

        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
