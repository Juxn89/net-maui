using net_maui.Views.Pages.GridLayout;

namespace net_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridLayoutSample();
        }
    }
}