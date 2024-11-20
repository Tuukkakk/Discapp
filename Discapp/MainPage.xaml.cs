using Microsoft.Maui.Controls;

namespace Discapp {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void OnStartButtonClicked(object sender, EventArgs e) {
            Navigation.PushAsync(new StartRound());
        }

        private async void OnManagePlayersButtonClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new ManagePlayersPage());
        }

        private void OnSavedRoundsButtonClicked(object sender, EventArgs e) {
        }

        private void OnExitButtonClicked(object sender, EventArgs e) {
            Environment.Exit(0);
        }
    }
}
