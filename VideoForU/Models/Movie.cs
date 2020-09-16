using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VideoForU.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
      
        public DateTime?  ReleaseDate { get; set; }

       
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        public int StockCount { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        
        public byte GenreId { get; set; }

    }
}