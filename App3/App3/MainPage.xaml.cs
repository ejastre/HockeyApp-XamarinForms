using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var crash = HockeyApp.CrashManager.DidCrashInLastSession;

            LabelCrash.Text += crash;

            NavigationPage.SetTitleIcon(this, "icon.png");

            //Label1.Text = $"ID: {CrossDeviceInfo.Current.Id} - " +
            //    $"Version: {CrossDeviceInfo.Current.Version} - " +
            //    $"Model: {CrossDeviceInfo.Current.Model} - " +
            //    $"Idiom: {CrossDeviceInfo.Current.Idiom} - " +
            //    $"Platform: {CrossDeviceInfo.Current.Platform} - " +
            //    $"VersionNumber: {CrossDeviceInfo.Current.VersionNumber} - ";
        }

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            HockeyApp.MetricsManager.TrackEvent(
                "Track Event Clicked",
                new Dictionary<string, string> {{"Time",DateTime.UtcNow.ToString()}},
                new Dictionary<string, double> {{"Value", 1.0}}
            );
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            throw new Exception("Quebrou aqui no botão");
        }
    }
}
