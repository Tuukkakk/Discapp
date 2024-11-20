using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;

namespace Discapp {
    public partial class StartRound : ContentPage {
        public List<Player> Players { get; set; }
        public List<Course> Courses { get; set; }
        public Course SelectedCourse { get; set; }

        public StartRound() {
            InitializeComponent();
            LoadPlayers();
            LoadCourses();
            BindingContext = this;
        }

        private void LoadPlayers() {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "players.json");

            if (File.Exists(filePath)) {
                var json = File.ReadAllText(filePath);
                Players = JsonConvert.DeserializeObject<List<Player>>(json) ?? new List<Player>();
            }
            else {
                Players = new List<Player>();
            }
        }

        private void LoadCourses() {
            Courses = CourseData.GetCourses();
        }

        private void OnCoursePickerChanged(object sender, EventArgs e) {
            if (CoursePicker.SelectedIndex != -1) {
                SelectedCourse = Courses[CoursePicker.SelectedIndex];
            }
        }

        private void OnStartRoundButtonClicked(object sender, EventArgs e) {
            var selectedPlayers = Players.Where(p => p.IsSelected).Select(p => p.Name).ToList();

            if (SelectedCourse != null && selectedPlayers.Any()) {
                Navigation.PushAsync(new PlayRoundPage(SelectedCourse, selectedPlayers));
            }
            else {
                DisplayAlert("Virhe", "Valitse pelaajat ja pelirata ennen kierroksen aloittamista.", "OK");
            }
        }
    }
}
