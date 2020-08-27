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
        /// Gets or sets the idAuctionHistory.
        /// </summary>
        [Key]
        public int idAuctionHistory { get; set; }

        /// <summary>
        /// Gets or sets the auctionId.
        /// </summary>
        public int? auctionId { get; set; }

        /// <summary>
        /// Gets or sets the userId.
        /// </summary>
        public int? userId { get; set; }

        /// <summary>
        /// Gets or sets the auctiondate.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime auctiondate { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double price { get; set; }

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
