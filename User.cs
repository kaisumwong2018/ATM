using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class User
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string PIN { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public string Accounttype { get; set; }
        public string AccountStatus { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }


    }
}
