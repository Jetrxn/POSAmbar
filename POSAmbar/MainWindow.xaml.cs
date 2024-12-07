using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Windowing;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using WinRT.Interop;

namespace POSAmbar
{
    public sealed partial class MainWindow : Window
    {

        private AppWindow m_appWindow;

        public MainWindow()
        {
            this.InitializeComponent();

            var windowHandle = WindowNative.GetWindowHandle(this);
            var windowId = Win32Interop.GetWindowIdFromWindow(windowHandle);
            m_appWindow = AppWindow.GetFromWindowId(windowId);

            // Configurar el presentador a modo maximizado
            m_appWindow.SetPresenter(AppWindowPresenterKind.FullScreen);

            // Obtener las dimensiones de la pantalla excluyendo la barra de tareas
            var displayArea = DisplayArea.GetFromWindowId(windowId, DisplayAreaFallback.Nearest);

            // Maximizar la ventana
            m_appWindow.Resize(new Windows.Graphics.SizeInt32
            {
                Width = displayArea.WorkArea.Width,
                Height = displayArea.WorkArea.Height
            });

            MainFrame.Navigate(typeof(Views.LoginView));

        }
    }
}
