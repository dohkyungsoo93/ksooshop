﻿using KsooShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsooShop.Model.Models
{
    [Table("Posts")]
    public class Post :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        [Required]
        public int CategoryID { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        [MaxLength(500)]
        public string Descripton { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }

    }
}
