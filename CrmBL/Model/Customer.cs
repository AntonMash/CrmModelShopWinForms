using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }
        
        public virtual ICollection<Check> Checks { get; set; }    // связь  с чеком


        public override string ToString()
        {
            return Name;
        }
    }
}
