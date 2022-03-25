using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class WalletTransactions
    {
        [Key]
        public int WalletId { get; set; }
        public int WalletBalance { get; set; }
        public int? DepositValue { get; set; }
        public int? WithdrawalValue { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime TransactionDate { get; set; }
        public int UserId { get; set; }

        //nav
        [ForeignKey("UserId")] 
        public Users Users { get; set; }
    }
}
