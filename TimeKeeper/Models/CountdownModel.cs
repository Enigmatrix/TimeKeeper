using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using NUnit.Framework;

namespace TimeKeeper.Models
{

    [TestFixture]
    public class CountdownModelTests
    {
        /*
         * Behavior Definition:
         * 
         *      Start:
         *          When Start() is called, Duration remains the same, but
         *          Remaining will start to change and call PropertyChanged,
         *          once every one second
         *          
         *      Stop:
         *          When Stop() is called, Duration remains the same, and
         *          Remaining will stop decreasing and stop calling PropertyChanged.
         *          
         *      Restart:
         *          When Restart() is called, Remaining is set equal to Duration.
         *          PropertyChanged should be called only once. The Remaining should
         *          not decrease anymore.
         *          
         *      Reset:
         *          When Reset(newDuration) is called, the timer stops. Duration and
         *          Remaining are set to newDuration. Both PropertyChanged are fired
         *          Neither Remaining and Duration should not decrease.
         */

        [Test]
        public void Duration_Set_FiresPropertyChanged()
        {
            var countdownModel = new CountdownModel();
            var durationChangedCount = 0;
            //set Duration to 5 seconds
            countdownModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "Duration")
                    durationChangedCount++;
            };
            countdownModel.Duration = new TimeSpan(0, 0, 0, 5);
            Assert.That(durationChangedCount, Is.EqualTo(1));
        }
        /*
        [Test]
        public void Start_MakesRemainingDecreaseOnceEveryOneSecond()
        {
            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                var countdownModel = new CountdownModel();
                var durationChangedCount = 0;
                var remainingChangedCount = 0;
                //set Duration to 5 seconds
                countdownModel.PropertyChanged += (sender, args) =>
                {
                    if (args.PropertyName == "Duration")
                        durationChangedCount++;
                    if (args.PropertyName == "Remaining")
                        remainingChangedCount++;
                };
                countdownModel.Duration = new TimeSpan(0, 0, 0, 5);
                Assert.That(countdownModel.Duration, Is.EqualTo(countdownModel.Remaining));
                countdownModel.Start();
                Assert.That(countdownModel.Remaining, Is.EqualTo(TimeSpan.FromSeconds(0)));
                Assert.That(durationChangedCount, Is.EqualTo(1));
                Assert.That(remainingChangedCount, Is.EqualTo(6));
            })
            ;
        }
         */


    }

    public class CountdownModel : ObservableObject
    {
        private TimeSpan _duration;
        private TimeSpan _remaining;
        private readonly TimeSpan _interval = TimeSpan.FromSeconds(1);

        private readonly DispatcherTimer _internalTimer;

        public CountdownModel()
        {
            _internalTimer = new DispatcherTimer
            {
                Interval = _interval
            };
            _internalTimer.Tick += delegate
            {
                Remaining = Remaining - _interval;
                if (Remaining <= TimeSpan.FromSeconds(0))
                {
                    Stop();
                    Remaining = TimeSpan.FromSeconds(0);
                }
            };
        }

        void TimeChanged()
        {
        }

        public TimeSpan Duration
        {
            get { return _duration; }
            set
            {
                Reset(value);
                RaisePropertyChanged();
            }
        }

        public TimeSpan Remaining
        {
            get { return _remaining; }
            private set
            {
                Set(ref _remaining, value);
            }
        }

        public void Reset(TimeSpan newDuration)
        {
            Stop();
            _duration = newDuration;
            Remaining = _duration;
        }

        public void Start()
        {
            _internalTimer.Start();
        }

        public void Stop()
        {
            _internalTimer.Stop();
        }

        public void Restart()
        {
            Stop();
            Remaining = Duration;
        }
    }
}
