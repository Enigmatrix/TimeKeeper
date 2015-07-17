using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FirstFloor.ModernUI.Presentation;
using GalaSoft.MvvmLight;
using TimeKeeper.Models;
using RelayCommand = GalaSoft.MvvmLight.CommandWpf.RelayCommand;

namespace TimeKeeper.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly CountdownModel CountdownModel;

        public MainViewModel()
        {
            //default time
            CountdownModel = new CountdownModel {Duration = new TimeSpan(0, 1, 1, 1)};
            CountdownModel.PropertyChanged += ModelPropertyChanged;


            StartCommand = new RelayCommand(StartCommandHandler);
            StopCommand = new RelayCommand(StopCommandHandler);
            ResetCommand = new RelayCommand(ResetCommandHandler);
            RestartCommand = new RelayCommand(RestartCommandHandler);
            CloseCommand = new RelayCommand(CloseCommandHandler);
            DarkThemeCommand = AppearanceManager.Current.DarkThemeCommand;
            LightThemeCommand = AppearanceManager.Current.LightThemeCommand;
        }

        protected void ModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // ReSharper disable once ExplicitCallerInfoArgument
            RaisePropertyChanged(e.PropertyName);
        }

        protected void StartCommandHandler()
        {
            CountdownModel.Start();
        }

        protected void StopCommandHandler()
        {
            CountdownModel.Stop();
        }

        protected void ResetCommandHandler()
        {
            //TODO:DAFUQ WAT TO DO
            CountdownModel.Reset(Time);
        }

        protected void RestartCommandHandler()
        {
            CountdownModel.Restart();
        }

        protected void CloseCommandHandler()
        {
            Application.Current.Shutdown();
        }


        public ICommand StartCommand { get; protected set; }

        public ICommand StopCommand { get; protected set; }

        public ICommand RestartCommand { get; protected set; }

        public ICommand ResetCommand { get; protected set; }

        public ICommand CloseCommand { get; protected set; }

        public ICommand DarkThemeCommand { get; protected set; }

        public ICommand LightThemeCommand { get; protected set; }

        public TimeSpan Time
        {
            get { return CountdownModel.Remaining; }
            set {/* you should not be able to set this*/ }
        }


    }
}
