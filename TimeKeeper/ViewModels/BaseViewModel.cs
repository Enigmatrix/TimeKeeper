using System.ComponentModel;
using GalaSoft.MvvmLight;

namespace TimeKeeper.ViewModels
{
    public interface IBaseViewModel : INotifyPropertyChanged
    {
    }

    public class BaseViewModel : ViewModelBase, IBaseViewModel
    {
    }
}