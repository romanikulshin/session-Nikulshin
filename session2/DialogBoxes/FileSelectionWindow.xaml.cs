using OOP_LB6_2.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace OOP_LB6_2.DialogBoxes
{
    /// <summary>
    /// Логика взаимодействия для FileSelectionWindow.xaml
    /// </summary>
    public partial class FileSelectionWindow : Window
    {
        public FileSelectionWindow(MainWindow main)
        {
            InitializeComponent();

            this.main = main;

            FiletoList();
            ShowFiles();
        }

        public MainWindow main;

        ObservableCollection<PlayerItem> FileList { get; set; }
        string[] files;

        public void FiletoList()
        {
            FileList = new ObservableCollection<PlayerItem>();
            files = Directory.GetFiles("media");

            foreach (string i in files)
            {
                string type = i.Substring(i.Length - 4, 4);
                string name = i.Substring(6, i.Length - 10);

                FileList.Add(new PlayerItem(i,name,type));
            }
        }
        public void ShowFiles()
        {
            List<string> result = new List<string>();

            foreach(PlayerItem i in FileList)
            {
                result.Add(i.Name+i.Type);
            }

            MediaContent.ItemsSource = result;
        }

        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string type = "";
            string name = "";
            foreach (PlayerItem i in FileList) 
            {
                if ((string)MediaContent.SelectedItem == (i.Name + i.Type))
                {
                    main.Player = i;
                    type = i.Type;
                    name = i.Name;
                }
            }
            main.SongName.Text = name;
            CloseFiles();
            CreateFileByType(type);
            Close();
        }
        private void CreateFileByType(string type)
        {
            switch (type)
            {
                case ".mp3":
                    main.mp3 = new MP3(main);
                    break;
                case ".wav":
                    main.wav = new WAV(main);
                    break;
                case ".mp4":
                    main.mp4 = new MP4(main);
                    break;
            }
        }
        private void CloseFiles()
        {
            if (main.mp3 != null)
            {
                main.mp3.Stop();
            }
            if (main.mp4 != null)
            {
                main.mp4.Stop();
            }
            if (main.wav != null)
            {
                main.wav.Stop();
            }
        }
    }
}
