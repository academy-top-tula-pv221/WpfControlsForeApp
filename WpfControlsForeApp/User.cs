using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlsForeApp
{
    internal class User
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public bool Married { set; get; }
        public Decimal Salary { set; get; }

        public override string ToString()
        {
            return $"{Name} ({Age}) {(Married ? "Married" : "Not Married")}";
        }
    }
}
