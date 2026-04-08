using Microsoft.Extensions.DependencyInjection;

namespace MAUIMessenger
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());

            int windowWidth = 800;
            int windowHeight = 600;

            window.Width = windowWidth;
            window.Height = windowHeight;

            window.MinimumWidth = 400;
            window.MinimumHeight = 300;

            var displayInfo = DeviceDisplay.Current.MainDisplayInfo;

            window.X = (displayInfo.Width / displayInfo.Density - windowWidth) / 2;
            window.Y = (displayInfo.Height / displayInfo.Density - windowHeight) / 2;

            return window;
        }
    }
}