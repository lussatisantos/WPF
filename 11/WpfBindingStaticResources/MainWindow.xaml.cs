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

namespace WpfBindingStaticResources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Site site;

        public MainWindow()
        {
            InitializeComponent();

            site = new Site();
            site.ID = 2;
            site.Nome = "Movie Aholic";
            site.Endereco = "movieaholic.com";

            Binding sb = new Binding();
            sb.Source = site;
            sb.Path = new PropertyPath("Endereco");

            textBox.SetBinding(TextBox.TextProperty, sb);

            /*
             
             */
        }
    }
}
