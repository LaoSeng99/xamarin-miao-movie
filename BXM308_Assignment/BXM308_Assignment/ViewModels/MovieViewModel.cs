using BXM308_Assignment.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BXM308_Assignment.ViewModels
{
    public class MovieViewModel : Movie
    {
        public double FirstStar => GetStarValue(1);
        public double SecondStar => GetStarValue(2);
        public double ThirdStar => GetStarValue(3);
        public double FourthStar => GetStarValue(4);
        public double FifthStar => GetStarValue(5);
        public double LastStar => StarRate / 5;
        public string DirectorNameList
        {
            get => string.Join(" · ", MovieDetails.Director.Select(x => x.Name));
        }
        public string DurationTime
        {
            get => $"{MovieDetails.Duration.Hours}h {MovieDetails.Duration.Minutes}m";
        }
        public string MoviePrice
        {
            get => Price.ToString("RM #,##0.00", new CultureInfo("ms-MY"));
        }
        private double GetStarValue(int star)
        {
            if (StarRate >= star)
            {
                return star == 5 ? StarRate - 4 : 1;
            }
            else if (Math.Floor(StarRate) == star - 1)
            {
                return StarRate - star + 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
