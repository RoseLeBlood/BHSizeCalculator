using System.Windows.Controls;
using System.Windows.Navigation;

namespace BHTool.View
{
    /// <summary>
    /// Interaktionslogik für FlyOutInfo.xaml
    /// </summary>
    public partial class FlyOutInfo : UserControl
    {
        public FlyOutInfo()
        {
            InitializeComponent();
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:annasophia.schroeck@ourlook.de");
        }
    }
}
