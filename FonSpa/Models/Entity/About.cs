namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
       
        public long id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(500)]
        public string metaTitle { get; set; }

        [StringLength(5000)]
        public string description { get; set; }

        [Column(TypeName = "ntext")]
        public string detail { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createdDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? modifiedDate { get; set; }

        public bool? status { get; set; }
    }
}
