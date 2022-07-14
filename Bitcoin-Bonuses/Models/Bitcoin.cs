using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bitcoin_Bonuses.Models
{
    public class Bitcoin
    {
        public int Id { get; set; }
        public int RowID { get; set; }

        public String BonusName { get; set; }
        public String Image { get; set; }
        public String ImageAlt { get; set; }
        public String ClaimNowURL { get; set; }
        public String SiteURL { get; set; }
        public String BannerSRC { get; set; }
        public String BonusInfo { get; set; }
        public String MoreInfo { get; set; }
        public String FlagIcon { get; set; }
        public String FlagIconAlt { get; set; }
        public String MoreInfoDetails { get; set; }
        public String BonusType { get; set; }
        
        public float BonusAmt { get; set; }
    }
}