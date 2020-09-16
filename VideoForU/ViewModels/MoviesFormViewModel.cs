using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoForU.Models;

namespace VideoForU.ViewModels
{
    public class MoviesFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movies { get; set; }
    }
}