using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _2_03_2023_nevsehir_mvc.Models
{
    [Table("gezilecekYerlerTable")]
    public class gezilecekYerlerTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string gYerAd { get; set; }
        public string gYerAciklama { get; set; }
        public string gYerResim { get; set; }
        public int sehirId { get; set; }
    }
}