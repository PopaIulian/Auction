namespace AuctionManagement.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Object")]
    public partial class Object
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Object()
        {
            Auctions = new HashSet<Auction>();
        }

        [Key]
        public int idObject { get; set; }

        [Required]
        [StringLength(20)]
        public string objectName { get; set; }

        public int? categoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auction> Auctions { get; set; }

        public virtual Category Category { get; set; }
    }
}
