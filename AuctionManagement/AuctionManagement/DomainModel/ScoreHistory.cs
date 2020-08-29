// <copyright file="ScoreHistory.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="ScoreHistory" />.
    /// </summary>
    [Table("ScoreHistory")]
    public partial class ScoreHistory
    {
        /// <summary>
        /// Gets or sets the IdScoreHistory.
        /// </summary>
        [Key]
        public int IdScoreHistory { get; set; }

        /// <summary>
        /// Gets or sets the DateScore.
        /// </summary>
        public DateTime DateScore { get; set; }

        /// <summary>
        /// Gets or sets the PersonId.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets the Score.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Gets or sets the Person.
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
