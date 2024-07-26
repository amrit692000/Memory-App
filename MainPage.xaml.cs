﻿namespace Memory_App
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // For demonstration purposes, we'll use hardcoded credentials.
            if (username == "user" && password == "password")
            {
                //await DisplayAlert("Login Success", "Welcome to the app!", "OK");
                // Navigate to the main page or another page after successful login
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Login Failed", "Invalid username or password", "OK");
            }
        }
    }

}
