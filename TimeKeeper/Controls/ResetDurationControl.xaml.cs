using System;
using System.Windows;
using System.Windows.Input;

namespace TimeKeeper.Controls
{
    /// <summary>
    ///     Interaction logic for ResetDurationControl.xaml
    /// </summary>
    public partial class ResetDurationControl
    {
        private static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof (TimeSpan), typeof (ResetDurationControl),
                new FrameworkPropertyMetadata(
                    ));

        // Register the routed event
        public static readonly RoutedEvent ValueSetEvent =
            EventManager.RegisterRoutedEvent("ValueSet", RoutingStrategy.Bubble,
                typeof (RoutedEventHandler), typeof (ResetDurationControl));

        public ResetDurationControl()
        {
            InitializeComponent();
        }

        public TimeSpan Value
        {
            get { return (TimeSpan) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // .NET wrapper
        public event RoutedEventHandler ValueSet
        {
            add { AddHandler(ValueSetEvent, value); }
            remove { RemoveHandler(ValueSetEvent, value); }
        }

        private void CheckIfEnterWasPressed(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //let`s only bother setting the Value
                //property when Enter was pressed
                Value = new TimeSpan(
                    HourControl.Value.GetValueOrDefault(),
                    MinuteControl.Value.GetValueOrDefault(),
                    SecondControl.Value.GetValueOrDefault());

                RaiseEvent(new RoutedEventArgs(ValueSetEvent));
            }
        }
    }
}