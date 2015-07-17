using System;
using System.Windows.Threading;

namespace TimeKeeper.Models
{
    public interface ICountdownModel : IModelBase
    {
        TimeSpan Duration { get; }
        TimeSpan Remaining { get; }
        bool IsCompleted { get; }
        bool IsRunning { get; }
        void Start();
        void Stop();
        void Restart();
        void Reset(TimeSpan newTime);
        //tracks changes to IsCompleted. IsCompleted is sent as the param
        event Action<bool> CompletedChanged;
    }

    public class CountdownModel : ModelBase, ICountdownModel
    {
        private static readonly TimeSpan DefaultDuration = TimeSpan.FromMinutes(30);
        private static readonly TimeSpan Interval = TimeSpan.FromSeconds(1);
        //we are using the wpf dispatcher timer
        private readonly DispatcherTimer _timer = new DispatcherTimer {Interval = Interval};
        private TimeSpan _duration = DefaultDuration;
        private bool _isCompleted;
        private bool _isRunning;
        private TimeSpan _remaining = DefaultDuration;

        public CountdownModel()
        {
            _timer.Tick += Tick;
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            private set
            {
                CompletedChanged(value);
                Set(ref _isCompleted, value);
            }
        }

        public bool IsRunning
        {
            get { return _isRunning;}
            set { Set(ref _isRunning, value); }
        }

        public TimeSpan Duration
        {
            get { return _duration; }
            private set { Set(ref _duration, value); }
        }

        public TimeSpan Remaining
        {
            get { return _remaining; }
            private set { Set(ref _remaining, value); }
        }

        public void Start()
        {
            _timer.Start();
            IsRunning = true;
        }

        public void Stop()
        {
            _timer.Stop();
            IsRunning = false;
        }

        public void Restart()
        {
            Stop();
            Remaining = Duration;
            IsCompleted = false;
        }

        public void Reset(TimeSpan newTime)
        {
            Stop();
            IsCompleted = false;
            Duration = Remaining = newTime;
        }

        public event Action<bool> CompletedChanged = completed => { };

        private void Tick(object sender, EventArgs e)
        {
            Remaining -= Interval;
            if (Remaining <= TimeSpan.Zero)
            {
                IsCompleted = true;
                Stop();
            }
        }
    }
}