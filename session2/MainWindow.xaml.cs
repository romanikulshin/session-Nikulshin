using OOP_LB6_2.Classes;
using OOP_LB6_2.DialogBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_LB6_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public PlayerItem Player { get; set; }

        public MP3 mp3 { get; set; }
        public WAV wav { get; set; }
        public MP4 mp4 { get; set; }

        private void MenuItem_Open_OnClick(object sender, RoutedEventArgs e)
        {
            FileSelectionWindow fileSelection = new FileSelectionWindow(this) { Owner = this };
            fileSelection.Show();
        }

        private void MenuItem_Close_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            switch (Player.Type)
            {
                case ".mp3":
                    mp3.Play();
                    break;
                case ".wav":
                    wav.Play();
                    break;
                case ".mp4":
                    mp4.Play();
                    break;
            }
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            switch (Player.Type)
            {
                case ".mp3":
                    mp3.Pause();
                    break;
                case ".wav":
                    wav.Pause();
                    break;
                case ".mp4":
                    mp4.Pause();
                    break;
            }
        }

        private void Record_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            switch (Player.Type)
            {
                case ".mp3":
                    mp3.Stop();
                    break;
                case ".wav":
                    wav.Stop();
                    break;
                case ".mp4":
                    mp4.Stop();
                    break;
            }
        }
    }
}
