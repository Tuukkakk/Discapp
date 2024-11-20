using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics.Text;
using System.Collections.Generic;
using System.Linq;

namespace Discapp {
    public partial class PlayRoundPage : ContentPage {
        private Course _selectedCourse;
        private int _currentHoleIndex;
        private List<PlayerScore> _playerScores;

        public PlayRoundPage(Course selectedCourse, List<string> players) {
            InitializeComponent();

            _selectedCourse = selectedCourse;
            _currentHoleIndex = 0;
            _playerScores = players.Select(p => new PlayerScore(p, selectedCourse.Holes.Count, selectedCourse.Holes.Sum(h => h.Par))).ToList();

            DisplayCurrentHole();
        }

        private void DisplayCurrentHole() {
            var currentHole = _selectedCourse.Holes[_currentHoleIndex];

            CourseNameLabel.Text = _selectedCourse.Name;
            HoleInfoLabel.Text = $"Väylä {currentHole.Number} | Par {currentHole.Par} | {currentHole.Meters} m";
            HoleImage.Source = currentHole.ImgLink;

            PlayerScoresStack.Children.Clear();
            foreach (var playerScore in _playerScores) {
                var grid = new Grid
                {
                    ColumnDefinitions = {
                new ColumnDefinition { Width = GridLength.Auto }, 
                new ColumnDefinition { Width = GridLength.Star },  
            },
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };

                var playerNameLabel = new Label
                {
                    Text = playerScore.Name,
                    FontSize = 16,
                    HorizontalOptions = LayoutOptions.Start,
                    TextColor = Colors.White

                };
                var relativeScore = playerScore.TotalScore - _selectedCourse.Holes.Sum(h => h.Par);
                var relativeScoreLabel = new Label
                {
                    Text = $"{(relativeScore >= 0 ? "+" : "")}{relativeScore}",
                    FontSize = 16,
                    HorizontalOptions = LayoutOptions.Start,
                    TextColor = Colors.White
                };

                var stackLeft = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 10
                };
                stackLeft.Children.Add(playerNameLabel);
                stackLeft.Children.Add(relativeScoreLabel);

                grid.Children.Add(stackLeft);
                Grid.SetColumn(stackLeft, 0); 
                var parScore = currentHole.Par + playerScore.GetScore(_currentHoleIndex);
                var parScoreLabel = new Label
                {
                    Text = $"{parScore}",
                    FontSize = 16,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Colors.White
                };

                var stackRight = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 5,
                    HorizontalOptions = LayoutOptions.End
                };

                var minusButton = new Button { Text = "-" };
                minusButton.Clicked += (s, e) => {
                    playerScore.DecreaseScore(_currentHoleIndex);
                    DisplayCurrentHole();
                };

                var plusButton = new Button { Text = "+" };
                plusButton.Clicked += (s, e) => {
                    playerScore.IncreaseScore(_currentHoleIndex);
                    DisplayCurrentHole();
                };

                stackRight.Children.Add(parScoreLabel);
                stackRight.Children.Add(minusButton);
                stackRight.Children.Add(plusButton);

                grid.Children.Add(stackRight);
                Grid.SetColumn(stackRight, 1); 

                PlayerScoresStack.Children.Add(grid);
            }

            EndRoundButton.IsVisible = _currentHoleIndex == _selectedCourse.Holes.Count - 1;

            PreviousHoleButton.IsEnabled = _currentHoleIndex > 0;
            NextHoleButton.IsEnabled = _currentHoleIndex < _selectedCourse.Holes.Count - 1;
        }



        private void OnPreviousHoleClicked(object sender, EventArgs e) {
            if (_currentHoleIndex > 0) {
                _currentHoleIndex--;
                DisplayCurrentHole();
            }
        }

        private void OnNextHoleClicked(object sender, EventArgs e) {
            if (_currentHoleIndex < _selectedCourse.Holes.Count - 1) {
                _currentHoleIndex++;
                DisplayCurrentHole();
            }
        }

        private async void OnCancelRoundClicked(object sender, EventArgs e) {
            var result = await DisplayAlert("Peruuta kierros", "Haluatko varmasti peruuttaa kierroksen?", "Kyllä", "Ei");
            if (result) {
                await Navigation.PopToRootAsync();
            }
        }

        private async void OnEndRoundClicked(object sender, EventArgs e) {
            var totalPar = _selectedCourse.Holes.Sum(h => h.Par);
            var summary = string.Join("\n", _playerScores.Select(p =>
                $"{p.Name}: Kokonaispisteet: {(p.TotalScore - totalPar >= 0 ? "+" : "")}{p.TotalScore - totalPar}"));

            await DisplayAlert("Kierroksen tulokset", summary, "OK");
            await Navigation.PopToRootAsync();
        }
    }

    public class PlayerScore {
        public string Name { get; }
        public List<int> Scores { get; } 
        public int TotalScore { get; private set; }

        public PlayerScore(string name, int holes, int initialScore) {
            Name = name;
            Scores = Enumerable.Repeat(0, holes).ToList();
            TotalScore = initialScore; 
        }

        public int GetScore(int holeIndex) => Scores[holeIndex];

        public void IncreaseScore(int holeIndex) {
            Scores[holeIndex]++;
            TotalScore++; 
        }

        public void DecreaseScore(int holeIndex) {
            Scores[holeIndex]--;
            TotalScore--; 
        }
    }
}
