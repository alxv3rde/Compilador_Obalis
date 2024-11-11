using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Compilador_AAA.Views;

namespace Compilador_AAA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TranslatorView translatorView = new TranslatorView();
            ContentPanel.Children.Add(translatorView);
            


        }





        private void Palabras_Reservadas_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PalabrasReservadasView palabrasReservadasView = new PalabrasReservadasView();
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(palabrasReservadasView);

        }

        private void TraductorMenu_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TranslatorView translatorView = new TranslatorView();
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(translatorView);
        }


        private void Window_Activated(object sender, EventArgs e)
        {
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
        }
    }
}