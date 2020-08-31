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
        public int idCategoryParent { get; set; }

        public int categoryId { get; set; }

        public int parentId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Category Category1 { get; set; }
    }
}
