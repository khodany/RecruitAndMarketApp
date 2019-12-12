using MarketingRecruit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketingRecruit.ViewModel
{
    public class RandomCustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public MembershipType MembershipType { get; set; }

      
    }
}