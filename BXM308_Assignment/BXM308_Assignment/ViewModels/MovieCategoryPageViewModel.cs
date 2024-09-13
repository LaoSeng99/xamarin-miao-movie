using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace BXM308_Assignment.ViewModels
{
    public class MovieCategoryPageViewModel : BaseViewModel
    {
        public MovieCategoryPageViewModel(ObservableCollection<MovieViewModel> movieList)
        {
            OriginalMovie = movieList;
        }

        protected override async void OnLoadCommandExecute()
        {

        }
        public ObservableCollection<MovieViewModel> OriginalMovie;

        private ObservableCollection<MovieViewModel> resultList;
        private ObservableCollection<string> filteredTagList;
        public ObservableCollection<MovieViewModel> ResultList
        {
            get => resultList;
            set => SetProperty(ref resultList, value);
        }
        public ObservableCollection<string> FilteredTagList
        {
            get => filteredTagList;
            set => SetProperty(ref filteredTagList, value);
        }
        private bool isSearching = false;

        public bool IsSearching
        {
            get => isSearching;
            set => SetProperty(ref isSearching, value);
        }

        public void SearchingMovie(string input)
        {
            List<MovieViewModel> filter = OriginalMovie.ToList();
            if (FilteredTagList?.Count > 0)
                filter = filter.Where(c => c.MovieDetails.GenreList.Any(g => FilteredTagList.Contains(g))).ToList();

            filter = filter.Where(c => c.MovieDetails.Title.ToLower()
                                             .Contains(input.ToLower()))
                                             .ToList();

            IsSearching = false;
            ResultList = new ObservableCollection<MovieViewModel>(filter);
        }
        public MovieViewModel GetSelectedMovie(string movieId)
        {
            var findMovie = ResultList.FirstOrDefault(c => c.MovieId == movieId);
            return findMovie;
        }
        public ObservableCollection<string> GetCategoriesString()
        {
            List<string> allGenres = new List<string>();

            // 遍历每部电影
            foreach (var movie in OriginalMovie)
            {
                // 拆分电影的流派并添加到总列表中
                List<string> genres = movie.MovieDetails.Genre.Split(',').ToList();
                allGenres.AddRange(genres);
            }
            return new ObservableCollection<string>(allGenres.Distinct());

        }
    }
}
