namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customertable")]
    public partial class customertable
    {
        [Key]
        [StringLength(20)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
