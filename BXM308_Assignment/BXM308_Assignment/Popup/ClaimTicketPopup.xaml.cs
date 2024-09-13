using BXM308_Assignment.Firebase;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClaimTicketPopup
    {
        private ClaimTicketPageViewModel viewModel;
        public ClaimTicketPopup(TicketVM ticket)
        {
            InitializeComponent();
            viewModel = new ClaimTicketPageViewModel(ticket);
            this.BindingContext = viewModel;
        }
        protected override void OnAppearing()
        {
            if (this.BindingContext is BaseViewModel viewModel)
                viewModel.LoadCommand.Execute(null);
        }
        private async void Nav_ClosePoup(object sender, EventArgs e)
        {//For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            await PopupNavigation.Instance.PopAsync();
            await Task.Delay(250);
            IsClicked = false;

        }

        private async void Complete_Clicked(object sender, EventArgs e)
        {//For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            if (viewModel.ClaimStatus == "Claimed")
            {
                await PopupNavigation.Instance.PopAsync();
                return;
            }
            viewModel.Ticket.Status = "Claimed";
            List<TicketVM> list = new List<TicketVM>();
            list.Add(viewModel.Ticket);
            await Firebase.Firebase.UpdateTicket(list);
            MessagingCenter.Send<App>((App)Application.Current, "Nav_ToTicket");
            await PopupNavigation.Instance.PopAsync();
            await Task.Delay(250);
            IsClicked = false;

        }
        private bool IsClicked = false;
        private void Block_Panel(object sender, EventArgs e)
        {
            return;
        }
    }
}