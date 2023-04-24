using System;
using System.Collections.Generic;

#nullable disable

namespace ObjectLibrary.ObjectLibrary
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public int GenreId { get; set; }
    }
}
