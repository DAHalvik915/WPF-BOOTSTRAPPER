using System;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace wpfbootstrap
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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //update
            Directory.Delete("NAME OF THE FILE YOU NAMED", true);
            WebClient webClient = new WebClient();
            string address = webClient.DownloadString("PASTE BIN LINK GOES HERE");
            webClient.DownloadFile(address, "");//NAME OF FILE YOU DOWNLOADING
            ZipFile.ExtractToDirectory("PUT NAME OF WHAT DOWNLOADING AGAIN IN HERE", "PUT WHAT EVER YOU WANT THE FILE TO BE NAMED");
            File.Delete("");//name of the zip that it downloaded

            MessageBox.Show("DONE NOW YOU CAN CLOSE THIS SCREEN");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //dowmload
            WebClient webClient = new WebClient();
            string address = webClient.DownloadString("PASTEBIN LINK");
            webClient.DownloadFile(address, "name of file your are downloading goes here");
            ZipFile.ExtractToDirectory("file that your download name goes here", "name this anything");
            File.Delete("name of file that you download goes here again");
            MessageBox.Show("DONE NOW YOU CAN CLOSE THIS SCREEN");
        }


        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bool flag = e.ChangedButton == MouseButton.Left;
            if (flag)
            {
                base.DragMove();
            }
        }

        
       

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }


        private void Button_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
