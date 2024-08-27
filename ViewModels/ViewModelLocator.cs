using CommunityToolkit.Mvvm.DependencyInjection;

namespace WpfAppControl.ViewModels
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => Ioc.Default.GetService<MainWindowViewModel>();
    }
}
