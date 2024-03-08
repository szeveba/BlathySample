using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameSample.Data
{
    internal class Book : Entity
    {
        public string? Title { get; set; }
        public Author? Author { get; set; }
        public DateTime? Published { get; set; }
        public GenreType? Genre { get; set; }
    }
}
