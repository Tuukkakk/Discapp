using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;

namespace Discapp {
    public partial class ManagePlayersPage : ContentPage {
        private List<Player> playerList;

        public ManagePlayersPage() {
            InitializeComponent();

            LoadPlayers();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e) {
            await Navigation.PopAsync();
        }

        private void OnAddPlayerButtonClicked(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(PlayerNameEntry.Text)) {
                playerList.Add(new Player { Name = PlayerNameEntry.Text }); 
                PlayerNameEntry.Text = ""; 

                SavePlayers(); 
                LoadPlayers(); 
            }
        }

        private void OnDeletePlayerButtonClicked(object sender, EventArgs e) {
            if (sender is Button button && button.BindingContext is Player player) {
                playerList.Remove(player); 
                SavePlayers(); 
                LoadPlayers(); 
            }
        }

        private void LoadPlayers() {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "players.json");

            if (File.Exists(filePath)) {
                var json = File.ReadAllText(filePath);
                playerList = JsonConvert.DeserializeObject<List<Player>>(json) ?? new List<Player>();
            }
            else {
                playerList = new List<Player>();
            }

            PlayersListView.ItemsSource = playerList;
        }

        private void SavePlayers() {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "players.json");
            var json = JsonConvert.SerializeObject(playerList);
            File.WriteAllText(filePath, json);
        }
    }

    public class Player {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}
