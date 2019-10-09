﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Check
    {

        public int CheckId { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }    // внешний ключ

        public int SellerId { get; set; }

        public virtual Seller Seller  { get; set; }    // здесь будет создаваться объект

        public DateTime Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }


        public override string ToString()
        {
            return $"№{CheckId} от {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
