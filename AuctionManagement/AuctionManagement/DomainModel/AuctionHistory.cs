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
        public int IdAuctionHistory { get; set; }

        public int? AuctionId { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Auctiondate { get; set; }

        public double Price { get; set; }

        public virtual Auction Auction { get; set; }

        public virtual Person Person { get; set; }
    }
}
