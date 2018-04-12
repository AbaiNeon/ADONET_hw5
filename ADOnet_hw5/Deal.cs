namespace ADOnet_hw5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Deal
    {
        [Key]
        public int Deal_id { get; set; }

        public int? seller_id { get; set; }

        public int? buyer_id { get; set; }

        public int sum { get; set; }

        [Column(TypeName = "date")]
        public DateTime deal_date { get; set; }

        public virtual Buyer Buyer { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
