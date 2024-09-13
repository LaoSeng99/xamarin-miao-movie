using System;
using System.Collections.Generic;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class Movie
    {
        public string Id { get; set; } //For Relationship
        public string MovieId { get; set; } // Firebase Key
        public string Poster { get; set; }
        public string TrailerLink { get; set; }
        public double StarRate { get; set; }
        public int Review { get; set; }
        public int Sales { get; set; }
        public string Rating { get; set; } // PG13
        public string ReleaseDate { get; set; }
        public double Price { get; set; }
        public bool IsShowing { get; set; }
        public MovieDetails MovieDetails { get; set; }
    }
}
