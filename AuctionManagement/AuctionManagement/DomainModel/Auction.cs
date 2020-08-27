namespace AuctionManagement.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Auction")]
    public partial class Auction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Auction()
        {
            AuctionHistories = new HashSet<AuctionHistory>();
        }

        [Key]
        public int idAuction { get; set; }

        public int objectId { get; set; }

        [Required]
        [StringLength(20)]
        public string currency { get; set; }

        public DateTime startData { get; set; }

        public DateTime? endData { get; set; }

        public int userId { get; set; }

        public decimal price { get; set; }

        public virtual Object Object { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuctionHistory> AuctionHistories { get; set; }
    }
}
