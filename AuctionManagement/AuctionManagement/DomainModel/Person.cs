namespace AuctionManagement.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Auctions = new HashSet<Auction>();
            AuctionHistories = new HashSet<AuctionHistory>();
        }

        [Key]
        public int idPerson { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        [Required]
        [StringLength(20)]
        public string personRole { get; set; }

        public int score { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auction> Auctions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuctionHistory> AuctionHistories { get; set; }
    }
}
