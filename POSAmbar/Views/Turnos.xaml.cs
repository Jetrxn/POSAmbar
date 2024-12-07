using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;

namespace POSAmbar.Views
{
    public sealed partial class TurnoView : Page
    {
        public TurnoView()
        {
            this.InitializeComponent();
        }

        private void NavigateToMonto_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MontoView));
        }
    }
}