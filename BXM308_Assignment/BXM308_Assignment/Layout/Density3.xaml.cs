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
    public partial class Density3 : ResourceDictionary
    {
        public static Density3 SharedInstance { get; } = new Density3();
        public Density3()
        {
            InitializeComponent();
        }
    }
}