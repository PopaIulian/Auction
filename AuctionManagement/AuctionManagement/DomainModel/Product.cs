// <copyright file="Product.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Product" />.
    /// </summary>
    [Table("Product")]
    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Auctions = new HashSet<Auction>();
        }

        /// <summary>
        /// Gets or sets the IdProduct.
        /// </summary>
        [Key]
        public int IdProduct { get; set; }

        /// <summary>
        /// Gets or sets the ObjectName.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Gets or sets the CategoryName.
        /// </summary>
        public int? CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the Auctions.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auction> Auctions { get; set; }

        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        public virtual Category Category { get; set; }
    }
}
