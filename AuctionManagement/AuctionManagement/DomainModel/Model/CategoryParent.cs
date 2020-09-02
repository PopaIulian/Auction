// <copyright file="CategoryParent.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="CategoryParent" />.
    /// </summary>
    [Table("CategoryParent")]
    public partial class CategoryParent
    {
        /// <summary>
        /// Gets or sets the IdCategoryParent.
        /// </summary>
        [Key]
        public int IdCategoryParent { get; set; }

        /// <summary>
        /// Gets or sets the CategoryId.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the ParentId.
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// Gets or sets the Category1.
        /// </summary>
        public virtual Category Category1 { get; set; }
    }
}
