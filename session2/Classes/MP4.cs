using OOP_LB6_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP_LB6_2.Classes
{
    public class MP4 : IPlayable
    {
        public MP4(MainWindow main)
        {
            this.main = main;
            videoElement = main.VideoElement;
            videoElement.Source = new Uri(main.Player.Url, UriKind.RelativeOrAbsolute);
            videoElement.LoadedBehavior = MediaState.Manual;
            videoElement.Volume = 1;
        }

        MainWindow main;

        private MediaElement videoElement;

        public void Pause()
        {
            videoElement.Pause();
        }

        public void Play()
        {
            videoElement.Play();
        }

        public void Stop()
        {
            videoElement.Stop();
            videoElement.Close();
        }
    }
}
