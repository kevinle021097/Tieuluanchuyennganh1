namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        public long id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(250)]
        public string metaTitle { get; set; }

        [StringLength(1500)]
        public string description { get; set; }

        [StringLength(100)]
        public string image { get; set; }

        [Column(TypeName = "xml")]
        public string moreImages { get; set; }

        public int ServingTime { get; set; }

        public decimal? price { get; set; }

        public decimal? promotionPrice { get; set; }

        public int? idCategory { get; set; }

        [Column(TypeName = "ntext")]
        public string detail { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createdDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? modifiDate { get; set; }

        public bool? status { get; set; }

        public int? viewCount { get; set; }
    }
}
