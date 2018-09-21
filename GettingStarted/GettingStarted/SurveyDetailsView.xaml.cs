using GettingStarted.Models;
using GettingStarted.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GettingStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SurveyDetailsView : ContentPage
    {
        public SurveyDetailsView()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", async (a, s) => 
            {
                await Navigation.PopModalAsync();
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey");
        }
    }
}