// <copyright file="Object.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Object" />.
    /// </summary>
    [Table("Object")]
    public partial class Object
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Object"/> class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Object()
        {
            Auctions = new HashSet<Auction>();
        }

        /// <summary>
        /// Gets or sets the idObject.
        /// </summary>
        [Key]
        public int idObject { get; set; }

        /// <summary>
        /// Gets or sets the objectName.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string objectName { get; set; }

        /// <summary>
        /// Gets or sets the categoryName.
        /// </summary>
        public int? categoryName { get; set; }

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
