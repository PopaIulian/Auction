// <copyright file="Person.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Person" />.
    /// </summary>
    [Table("Person")]
    public partial class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Auctions = new HashSet<Auction>();
            AuctionHistories = new HashSet<AuctionHistory>();
            ScoreHistories = new HashSet<ScoreHistory>();
        }

        /// <summary>
        /// Gets or sets the IdPerson.
        /// </summary>
        [Key]
        public int IdPerson { get; set; }

        /// <summary>
        /// Gets or sets the Username.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the PersonRole.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string PersonRole { get; set; }

        /// <summary>
        /// Gets or sets the Score.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Gets or sets the DateWrongScore.
        /// </summary>
        public DateTime? DateWrongScore { get; set; }

        /// <summary>
        /// Gets or sets the Auctions.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auction> Auctions { get; set; }

        /// <summary>
        /// Gets or sets the AuctionHistories.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuctionHistory> AuctionHistories { get; set; }

        /// <summary>
        /// Gets or sets the ScoreHistories.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScoreHistory> ScoreHistories { get; set; }
    }
}
