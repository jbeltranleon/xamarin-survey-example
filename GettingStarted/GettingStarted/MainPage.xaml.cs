using GettingStarted.ViewModels;
using Xamarin.Forms;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<MainPageViewModel>(this, "AddSurvey", async (a) =>
                {
                    await Navigation.PushModalAsync(new SurveyDetailsView());
                });
        }
    }
}
