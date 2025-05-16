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
    [Table("Transactions")]
    public class Transactions
    {
        [Key]
        [Required]
        public int trans_id { get; set; }
        [Required]
        public int account_id { get; set; } 

        [Required]
        public DateTime happened_time { get; set; }

        [StringLength(50)]
        public string action_desc { get; set; }

        [StringLength(50)]
        public string note { get; set; }

        public Transactions(int account_id, DateTime happened_time, string action_desc, string note)
        {
 
            this.account_id = account_id;
            this.happened_time = happened_time;
            this.action_desc = action_desc;
            this.note = note;
        }
    }
}
