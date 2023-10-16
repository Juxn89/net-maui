using net_maui.Views.Pages.AbsoluteLayout;

namespace net_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsoluteLayoutSample();
        }
    }
}