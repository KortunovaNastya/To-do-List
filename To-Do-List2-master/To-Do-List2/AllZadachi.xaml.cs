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
using System.Windows.Shapes;

namespace To_Do_List2
{
    /// <summary>
    /// Логика взаимодействия для AllZadachi.xaml
    /// </summary>
    public partial class AllZadachi : Window
    {
        public AllZadachi()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
