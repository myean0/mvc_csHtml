using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _2_03_2023_nevsehir_mvc.Models
{
    [Table("sliderTable")]
    public class sliderTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SliderResim { get; set; }
        public string SliderBaslik { get; set; }
        public string SliderAciklama { get; set; }
        public int sehirId { get; set; }
    }
}
