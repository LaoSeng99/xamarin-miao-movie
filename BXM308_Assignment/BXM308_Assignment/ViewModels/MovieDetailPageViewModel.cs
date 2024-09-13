using BXM308_Assignment.PageViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BXM308_Assignment.ViewModels
{
    public class MovieDetailPageViewModel : BaseViewModel
    {
        public MovieDetailPageViewModel(MovieViewModel movie)
        {
            Movie = movie;
        }
        protected override void OnLoadCommandExecute()
        {
            if (IsDataLoad)
                return;
            IsDataLoad = true;
        }
        private bool IsDataLoad = false;
        private MovieViewModel movie;
        public MovieViewModel Movie
        {
            get => movie;
            set => SetProperty(ref movie, value);
        }
    }
}
