using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XamarinMvvmReference.Mvvm.Core.ViewModels;
using XamarinMvvmReference.Services;

namespace XamarinMvvmReference.Mvvm.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IPersonService, PersonService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<PersonListViewModel>());
        }
    }
}
