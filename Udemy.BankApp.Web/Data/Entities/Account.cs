using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy.BankApp.Web.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }

        public decimal Balance { get; set; }

        public int AccountNumber { get; set; }

        public int ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
