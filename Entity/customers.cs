﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class customers
    {
        public int customer_id { get; set; }

     
        public string name { get; set; }

    
        public string address { get; set; }

        public string phone { get; set; }

       
        public bool active { get; set; }
    }
}
