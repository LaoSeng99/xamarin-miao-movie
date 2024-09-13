
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loading
    {
        public Loading()
        {
            InitializeComponent();


            MessagingCenter.Subscribe<App, string>((App)Application.Current, "UpdateReloadStatus", (sender, status) =>
            {
                StatusLabel.Text = status;
                switch (status)
                {
                    case "Step0":
                        StatusLabel.Text = "Deleting old data";
                        EstimateLabel.Text = "approximately 1 to 5 seconds.";
                        break;
                    case "Step1":
                        StatusLabel.Text = "Creating Room";
                        EstimateLabel.Text = "approximately 1 to 5 seconds.";
                        break;
                    case "Step2":
                        StatusLabel.Text = "Creating Showtimes";
                        EstimateLabel.Text = "approximately 70 to 210 seconds (1 to 3.5 minutes).";
                        break;
                    case "Step3":
                        StatusLabel.Text = "Updating Showtimes";
                        EstimateLabel.Text = "approximately 140 to 280 seconds (2.5 to 5 minutes).";
                        break;
                    case "Step4":
                        StatusLabel.Text = "Creating Seats";
                        EstimateLabel.Text = "approximately 210 to 350 seconds (3.5 to 6 minutes).";
                        break;

                }

            });
        }
    }
}

