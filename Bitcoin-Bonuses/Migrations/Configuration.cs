namespace Bitcoin_Bonuses.Migrations
{
    using Bitcoin_Bonuses.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bitcoin_Bonuses.Models.BitcoinTradingDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Bitcoin_Bonuses.Models.BitcoinTradingDB context)
        {
            
        }
    }
}
