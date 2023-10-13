using net_maui.Views.Pages.FlyoutSample;
using net_maui.Views.Pages.TabbedPageSample;

namespace net_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPageSample();
        }
    }
}