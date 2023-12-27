using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _2_03_2023_nevsehir_mvc.Models
{
    [Table("sehirTable")]
    public class sehirTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Sehir { get; set; }
        public string SehirAciklama { get; set; } 
        public string AltBaslik { get; set; }
    }
}
