using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment.Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Density2_75 : ResourceDictionary
    {
        public static Density2_75 SharedInstance { get; } = new Density2_75();
        public Density2_75()
        {
            InitializeComponent();
        }
    }
}