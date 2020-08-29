// <copyright file="AuctionHistory.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="AuctionHistory" />.
    /// </summary>
    [Table("AuctionHistory")]
    public partial class AuctionHistory
    {
        /// <summary>
        /// Gets or sets the IdAuctionHistory.
        /// </summary>
        [Key]
        public int IdAuctionHistory { get; set; }

        /// <summary>
        /// Gets or sets the AuctionId.
        /// </summary>
        public int AuctionId { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the Auctiondate.
        /// </summary>
        public DateTime Auctiondate { get; set; }

        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the Auction.
        /// </summary>
        public virtual Auction Auction { get; set; }

        /// <summary>
        /// Gets or sets the Person.
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
