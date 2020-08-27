// <copyright file="Person.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DomainModel
{
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
        }

        /// <summary>
        /// Gets or sets the idPerson.
        /// </summary>
        [Key]
        public int idPerson { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string username { get; set; }

        /// <summary>
        /// Gets or sets the personRole.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string personRole { get; set; }

        /// <summary>
        /// Gets or sets the score.
        /// </summary>
        public int score { get; set; }

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
    }
}
