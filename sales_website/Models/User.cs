namespace sales_website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int id { get; set; }

        [StringLength(50)]
        public string role { get; set; }

        [StringLength(50)]
        public string nomComplet { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }

        [StringLength(50)]
        public string adresse { get; set; }

        [StringLength(50)]
        public string specialite { get; set; }

        [StringLength(10)]
        public string tel { get; set; }

        [StringLength(10)]
        public string email { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        public int? idCommandeF { get; set; }

        public virtual Commande Commande { get; set; }

        public virtual UserProduit UserProduit { get; set; }
    }
}
