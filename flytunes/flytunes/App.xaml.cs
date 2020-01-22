using Prism;
using Prism.Ioc;
using FlyTunes.Model.Security;
using FlyTunes.Services;
using FlyTunes.Services.Interfaces;
using FlyTunes.ViewModels;
using FlyTunes.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FlyTunes
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MainView/NavigationPage/LoginView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
          
            containerRegistry.RegisterSingleton<ISecurityService, FakeSecurityService>();
            containerRegistry.RegisterSingleton<IUserProfile, UserProfile>();
     

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainView, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<OtherView, OtherViewViewModel>();
            containerRegistry.RegisterForNavigation<LoginView, LoginViewViewModel>();       
        }
    }
}
