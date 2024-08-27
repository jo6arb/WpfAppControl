using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfAppControl.ViewModels;

namespace WpfAppControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Ioc.Default.ConfigureServices(new ServiceCollection().AddTransient<MainWindow>()
                                                                                        .AddTransient<MainWindowViewModel>()
                                                                                        .BuildServiceProvider());
        }
    }

}
