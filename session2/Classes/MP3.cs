using OOP_LB6_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP_LB6_2.Classes
{
    public class MP3 : IRecordable, IPlayable
    {
        public MP3(MainWindow main)
        {
            this.main = main;
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri(main.Player.Url,UriKind.RelativeOrAbsolute));

            element = main.VideoElement;
            element.Source = new Uri("screensaver\\screensaver.mp4", UriKind.RelativeOrAbsolute);
            element.LoadedBehavior = MediaState.Manual;
            element.Volume = 0;
        }

        MainWindow main;
        MediaPlayer mediaPlayer;

        private MediaElement element;


        public void Pause()
        {
            element.Pause();
            mediaPlayer.Pause();
        }

        public void Play()
        {
            element.Play();
            mediaPlayer.Play();
        }

        public void Record()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            element.Stop();
            mediaPlayer.Stop();
        }
    }
}
