﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop_Web.Models.Flower_ViewModels
{
    public class SRDDServiceVM
    {
        public int ID { get; set; }
        public int ID_StockReceivedDocket { get; set; }
        public int ID_Material { get; set; }
        public int StockReceived_Quantity { get; set; }
    }
}