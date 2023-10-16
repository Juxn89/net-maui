using net_maui.Views.Pages.StackLayout;

namespace net_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayoutSamplePage();
        }
    }
}