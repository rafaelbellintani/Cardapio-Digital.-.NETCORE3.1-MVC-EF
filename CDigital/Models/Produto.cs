using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CDigital.Models
{
    [Table("Products")]

    public class Produto
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Column("Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        [Column("Price")]
        public string Price { get; set; }

        [Display(Name = "Description")]
        [Column("Description")]
        public string Description { get; set; }

    }
}
