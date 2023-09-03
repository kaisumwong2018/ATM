﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime DateTime { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int SourceAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public string TransactionStatus { get; set; }

    }
}
