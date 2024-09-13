using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class MovieDetails
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public List<string> GenreList { get => Genre.Replace(" ", "").Split(',').ToList(); }
        public ObservableCollection<Actor> Actor { get; set; }
        public ObservableCollection<Director> Director { get; set; }
        public string Language { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public ObservableCollection<MovieImage> Image { get; set; }
    }
}
