using BakeryEvdokimovKulikovv.Windows;
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

namespace BakeryEvdokimovKulikovv
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Avtorization_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow reg = new RegistrationWindow();
            this.Close();
            reg.Show();
        }

        


    }

}
