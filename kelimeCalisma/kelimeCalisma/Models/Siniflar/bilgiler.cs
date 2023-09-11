using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace kelimeCalisma.Models.Siniflar
{
    public class bilgiler
    {
        [Key]
        public int kelimeid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string kelime { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string kelimeAnlam { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string kelimeKullanim { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string kelimeNot { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string kelimeTarih { get; set; }
    }
}