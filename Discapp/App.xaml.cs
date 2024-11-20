using Microsoft.Maui.Controls;

namespace Discapp {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromArgb("#1c1c1c"),
                BarTextColor = Colors.White
            };
        }
    }
}
