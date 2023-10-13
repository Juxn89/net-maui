using net_maui.Views.Pages.FlyoutSample;

namespace net_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutSamplePage();
        }
    }
}