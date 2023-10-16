using net_maui.Views.Pages.Flexlayout;

namespace net_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlexlayoutChallengeExtra();
        }
    }
}