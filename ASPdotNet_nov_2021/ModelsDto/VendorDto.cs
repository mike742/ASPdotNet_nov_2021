﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNet_nov_2021.ModelsDto
{
    public class VendorDto
    {
        public int V_code { get; set; } // PK
        public string V_name { get; set; }
        public string V_contact { get; set; }
        public int V_AreaCode { get; set; }
        public string V_phone { get; set; }
        public string V_state { get; set; }
        public string V_order { get; set; }

    }
}
