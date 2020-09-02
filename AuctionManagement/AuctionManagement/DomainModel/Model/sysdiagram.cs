// <copyright file="sysdiagram.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="Sysdiagram" />.
    /// </summary>
    public partial class Sysdiagram
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the principal_id.
        /// </summary>
        public int Principal_id { get; set; }

        /// <summary>
        /// Gets or sets the diagram_id.
        /// </summary>
        [Key]
        public int Diagram_id { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Gets or sets the definition.
        /// </summary>
        public byte[] Definition { get; set; }
    }
}
