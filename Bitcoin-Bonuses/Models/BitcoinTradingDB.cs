using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bitcoin_Bonuses.Models
{
    public class BitcoinTradingDB : DbContext
    {
        public BitcoinTradingDB() : base("name=DefaultConnection")
        {

        }

        public DbSet<Bitcoin> Bitcoin { get; set; }
    }
}