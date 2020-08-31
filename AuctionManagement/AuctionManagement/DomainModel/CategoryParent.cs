namespace AuctionManagement.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryParent")]
    public partial class CategoryParent
    {
        [Key]
        public int IdCategoryParent { get; set; }

        public int CategoryId { get; set; }

        public int ParentId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Category Category1 { get; set; }
    }
}
