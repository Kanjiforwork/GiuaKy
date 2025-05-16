using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WindowsFormsApp1.Model
{
    [Table("BankAccount")]
    public class Bank_account
    {
        [Key]
        [Required]
        public int account_id { get; set; }

        [StringLength(150)]

        public string owner_name { get; set; }

        [StringLength(150)]

        public string owner_address { get; set; }

        [StringLength(13)]
  
        public string owner_phone { get; set; }


        public double balance { get; set; }

        public string accout_type { get; set; }

        public string password { get; set; }  
      

        public Bank_account( string owner_name, string owner_address, string owner_phone, double balance, string accout_type, string password)
        {
           
            this.owner_name = owner_name;
            this.owner_address = owner_address;
            this.owner_phone = owner_phone;
            this.balance = balance;
            this.accout_type = accout_type;
            this.password = password;
        }


    }
}
