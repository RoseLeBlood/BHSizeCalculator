using BHTool.Daten;
using MahApps.Metro.Controls;
using System.Windows;

namespace BHTool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmdInfo_Click(object sender, RoutedEventArgs e)
        {
            flOutInfo.IsOpen = !flOutInfo.IsOpen;
        }

        private void slUnterUmfang_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void slUmfang_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                var bh = new BH(lblunu.Content.ToString(),
                                lblob.Content.ToString());
                txtbh.Text = bh.ToString();
            }
            catch
            {
                if (txtbh != null) txtbh.Text = "-- -";
            }
        }
    }
}
