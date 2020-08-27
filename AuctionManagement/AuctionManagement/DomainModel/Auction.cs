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
        /// Gets or sets the idAuction.
        /// </summary>
        [Key]
        public int idAuction { get; set; }

        /// <summary>
        /// Gets or sets the objectId.
        /// </summary>
        public int objectId { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string currency { get; set; }

        /// <summary>
        /// Gets or sets the startData.
        /// </summary>
        public DateTime startData { get; set; }

        /// <summary>
        /// Gets or sets the endData.
        /// </summary>
        public DateTime? endData { get; set; }

        /// <summary>
        /// Gets or sets the userId.
        /// </summary>
        public int userId { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// Gets or sets the Object.
        /// </summary>
        public virtual Object Object { get; set; }

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
