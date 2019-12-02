using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactHomeWindowsFormsApp.Data.Model
{
    class SubCategories
    {
        public int Id{ get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
