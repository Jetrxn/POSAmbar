using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;

namespace POSAmbar.Views
{
    public sealed partial class LoginView : Page
    {
        public LoginView()
        {
            this.InitializeComponent();
        }

        private async void OnLoginButtonClick(object sender, RoutedEventArgs e)
        {
            // Aquí ira la logica para validar el usuario y la contraseña
            if (IsValidUser(UsernameTextBox.Text, PasswordBox.Password))
            {
                // Navegar a la vista de turno
                Frame.Navigate(typeof(TurnoView));
            }
            else
            {
                var dialog = new ContentDialog
                {
                    Title = "Error",
                    Content = "Usuario o contraseña incorrectos",
                    CloseButtonText = "Ok",
                    XamlRoot = this.XamlRoot
                };
                await dialog.ShowAsync();
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Implementa tu logica de validación aqui
            return username == "admin" && password == "admin"; // Ejemplo simple
        }
    }
}
