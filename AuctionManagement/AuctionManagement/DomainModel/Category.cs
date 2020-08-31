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
        public Category()
        {
            this.CategoryParents = new HashSet<CategoryParent>();
            this.CategoryParents1 = new HashSet<CategoryParent>();
            this.Products = new HashSet<Product>();
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
        /// Gets or sets the CategoryParents.
        /// </summary>
        public virtual ICollection<CategoryParent> CategoryParents { get; set; }

        /// <summary>
        /// Gets or sets the CategoryParents1.
        /// </summary>
        public virtual ICollection<CategoryParent> CategoryParents1 { get; set; }

        /// <summary>
        /// Gets or sets the Products.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
