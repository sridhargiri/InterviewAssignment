using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class RuleItem
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }
        public string Rule { get; set; }
        public bool IsCommission { get; set; }
        public bool IsEmail { get; set; }
        public string Message { get; set; }
    }
}
