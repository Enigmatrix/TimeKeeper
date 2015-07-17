using System.ComponentModel;
using GalaSoft.MvvmLight;

namespace TimeKeeper.Models
{
    public interface IModelBase : INotifyPropertyChanged
    {
    }

    public class ModelBase : ObservableObject, IModelBase
    {
    }
}