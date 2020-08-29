// <copyright file="Category.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Category" />.
    /// </summary>
    [Table("Category")]
    public partial class Category
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Category1 = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        /// <summary>
        /// Gets or sets the IdCategory.
        /// </summary>
        [Key]
        public int IdCategory { get; set; }

        /// <summary>
        /// Gets or sets the CategoryName.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the ParentId.
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Gets or sets the Category1.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Category1 { get; set; }

        /// <summary>
        /// Gets or sets the Category2.
        /// </summary>
        public virtual Category Category2 { get; set; }

        /// <summary>
        /// Gets or sets the Products.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
