﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BdCoin.ViewModel
{
    public class transactionsVM
    {
        public int Id { get; set; }
        public int chainId { get; set; }
        public double amount { get; set; }
        public string receiver { get; set; }
        public string sender { get; set; }
    }
}
