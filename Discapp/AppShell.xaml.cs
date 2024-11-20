using Microsoft.Maui.Controls;

namespace Discapp {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();
        }

        private void OnHomeButtonClicked(object sender, EventArgs e) {
            Navigation.PopToRootAsync();
        }

        private void OnExitButtonClicked(object sender, EventArgs e) {
            Environment.Exit(0);
        }
    }
}
