// <copyright file="Config.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Config" />.
    /// </summary>
    [Table("Config")]
    public partial class Config
    {
        /// <summary>
        /// Gets or sets the IdConfig.
        /// </summary>
        [Key]
        [StringLength(20)]
        public string IdConfig { get; set; }

        /// <summary>
        /// Gets or sets the ValueConfig.
        /// </summary>
        public int ValueConfig { get; set; }
    }
}
