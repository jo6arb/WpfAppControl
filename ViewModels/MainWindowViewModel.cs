using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppControl.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Контроль указаний";

    }
}
