using CommunityToolkit.Maui.Views;

namespace Testing_Popups
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnDisplayPopupClicked(object sender, EventArgs e)
        {
            await DisplayPopup();
        }
        public async static Task DisplayPopup()
        {
            var popup = new SimplePopup();            
            await App.Current.MainPage.ShowPopupAsync(popup);
        }
    }
}