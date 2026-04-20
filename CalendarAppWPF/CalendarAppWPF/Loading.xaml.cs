using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace CalendarAppWPF
{
    public partial class Loading : Window
    {
        private DispatcherTimer dotsTimer;
        private int dotCount = 0;

        public Loading()
        {
            InitializeComponent();

            StartBarAnimation();
            StartDotsAnimation();
        }

        private void StartBarAnimation()
        {
            DoubleAnimation move = new DoubleAnimation
            {
                From = -60,
                To = 220,
                Duration = TimeSpan.FromSeconds(1.6),
                RepeatBehavior = RepeatBehavior.Forever
            };

            BarTransform.BeginAnimation(TranslateTransform.XProperty, move);
        }

        private void StartDotsAnimation()
        {
            dotsTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(400)
            };

            dotsTimer.Tick += (s, e) =>
            {
                dotCount = (dotCount + 1) % 4;
                StatusText.Text = "Setting up your calendar" + new string('.', dotCount);
            };

            dotsTimer.Start();
        }
    }
}