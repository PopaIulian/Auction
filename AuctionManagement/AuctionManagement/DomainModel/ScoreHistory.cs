namespace AuctionManagement.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScoreHistory")]
    public partial class ScoreHistory
    {
        [Key]
        public int IdScoreHistory { get; set; }

        public DateTime DateScore { get; set; }

        public int PersonId { get; set; }

        public int Score { get; set; }

        public virtual Person Person { get; set; }
    }
}
