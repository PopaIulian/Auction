// <copyright file="Auction.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Auction" />.
    /// </summary>
    [Table("Auction")]
    public partial class Auction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auction"/> class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Auction()
        {
            AuctionHistories = new HashSet<AuctionHistory>();
        }

        /// <summary>
        /// Gets or sets the IdAuction.
        /// </summary>
        [Key]
        public int IdAuction { get; set; }

        /// <summary>
        /// Gets or sets the ObjectId.
        /// </summary>
        public int ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the EndDate.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the Product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets the Person.
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the AuctionHistories.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuctionHistory> AuctionHistories { get; set; }
    }
}
