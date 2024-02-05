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

namespace WpfListView
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

        private void btInserir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listView.Items.Add(txtValor.Text);
                txtValor.Clear();
            } catch {
                MessageBox.Show("Informe um valor para ser inserido no ListView");
            }
        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listView.Items.RemoveAt(listView.Items.IndexOf(listView.SelectedItem));
            }
            catch
            {
                MessageBox.Show("Selecione um valor no ListView para ser removido");
            }
        }

       
    }
}
