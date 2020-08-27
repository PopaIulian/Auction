namespace AuctionManagement.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuctionHistory")]
    public partial class AuctionHistory
    {
        [Key]
        public int idAuctionHistory { get; set; }

        public int? auctionId { get; set; }

        public int? userId { get; set; }

        [Column(TypeName = "date")]
        public DateTime auctiondate { get; set; }

        public double price { get; set; }

        public virtual Auction Auction { get; set; }

        public virtual Person Person { get; set; }
    }
}
