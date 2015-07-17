using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;
using GalaSoft.MvvmLight.CommandWpf;
using TimeKeeper.Models;
using RelayCommand = GalaSoft.MvvmLight.CommandWpf.RelayCommand;

namespace TimeKeeper.ViewModels
{
    public interface IMainViewModel : IBaseViewModel
    {
        ICommand SwitchThemeCommand { get; }
        ICommand StartCommand { get; }
        ICommand StopCommand { get; }
        ICommand ResetCommand { get; }
        ICommand RestartCommand { get; }
        ICommand CloseCommand { get; }
        TimeSpan Remaining { get; }
        string NextThemeName { get; }
        bool InResetMode { get; }
        bool IsCompleted { get; }
    }

    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        private readonly ICountdownModel _countdown = new CountdownModel();
        private readonly MediaPlayer _sound = new MediaPlayer();
        private readonly Uri _soundFileUri = new Uri(@"Media\clock_alarm_sound.wav", UriKind.Relative);
        private bool _inResetMode;
        //assuming we are currently at the Dark theme, the next theme will be the Light theme
        private string _nextThemeName = "Light Theme";

        public MainViewModel()
        {
            _countdown.PropertyChanged += TriggerPropertyChange;
            _countdown.CompletedChanged += CompletedChangedTriggered;
            _sound.Open(_soundFileUri);
            _sound.MediaEnded += Repeat;

            StartCommand = new RelayCommand(StartCommandHandler, () => !IsCompleted);
            StopCommand = new RelayCommand(StopCommandHandler, () => !IsCompleted);
            GoToResetModeCommand = new RelayCommand(GoToResetModeCommandHandler);
            ResetCommand = new RelayCommand<TimeSpan>(ResetCommandHandler);
            RestartCommand = new RelayCommand(RestartCommandHandler);
            SwitchThemeCommand = new RelayCommand(SwitchThemeCommandHandler);
            CloseCommand = new RelayCommand(CloseCommandHandler);
            //for the sake of debugging the sound
#if DEBUG
            _countdown.Reset(TimeSpan.FromSeconds(2));
            _countdown.Start();
#endif
        }

        public ICommand GoToResetModeCommand { get; private set; }
        public ICommand SwitchThemeCommand { get; private set; }
        public ICommand StartCommand { get; private set; }
        public ICommand StopCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }
        public ICommand RestartCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }

        public TimeSpan Remaining
        {
            get { return _countdown.Remaining; }
        }

        public string NextThemeName
        {
            get { return _nextThemeName; }
            set { Set(ref _nextThemeName, value); }
        }

        public bool IsCompleted
        {
            get { return _countdown.IsCompleted; }
        }

        public bool InResetMode
        {
            get { return _inResetMode; }
            set { Set(ref _inResetMode, value); }
        }

        public void SwitchThemeCommandHandler()
        {
            if (NextThemeName == "Light Theme")
            {
                NextThemeName = "Dark Theme";
                AppearanceManager.Current.LightThemeCommand.Execute(null);
            }
            else
            {
                NextThemeName = "Light Theme";
                AppearanceManager.Current.DarkThemeCommand.Execute(null);
            }
        }

        private void StartCommandHandler()
        {
            InResetMode = false;
            _countdown.Start();
        }

        private void StopCommandHandler()
        {
            InResetMode = false;
            _countdown.Stop();
        }

        private void GoToResetModeCommandHandler()
        {
            //TODO: do this later on
            _countdown.Stop();
            InResetMode = true;
            //if the Sound is playing when i go to the reset mode, stop it
            _sound.Pause();
        }

        private void ResetCommandHandler(TimeSpan newValue)
        {
            InResetMode = false;
            _countdown.Reset(newValue);
        }

        private void RestartCommandHandler()
        {
            InResetMode = false;
            _countdown.Restart();
        }

        private void CloseCommandHandler()
        {
            Application.Current.Shutdown();
        }

        private void TriggerPropertyChange(object sender, PropertyChangedEventArgs e)
        {
            RaisePropertyChanged(e.PropertyName);
        }

        private void CompletedChangedTriggered(bool completed)
        {
            if (completed)
            {
                _sound.Play();
            }
            else
            {
                _sound.Pause();
            }
        }

        private void Repeat(object sender, EventArgs e)
        {
            _sound.Position = TimeSpan.Zero;
            _sound.Play();
        }
    }
}