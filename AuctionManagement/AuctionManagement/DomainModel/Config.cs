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
        /// Gets or sets the idConfig.
        /// </summary>
        [Key]
        [StringLength(10)]
        public string idConfig { get; set; }

        /// <summary>
        /// Gets or sets the valueConfig.
        /// </summary>
        public int valueConfig { get; set; }
    }
}
