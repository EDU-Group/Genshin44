using gs;
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

namespace gs44.pages.home.update.content
{
    /// <summary>
    /// c01.xaml 的交互逻辑
    /// </summary>
    public partial class c01 : Page
    {
        public c01()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PageI = "/pages/home/page1.xaml";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PageI = "/pages/home/js/jspg.xaml";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PageI = "/pages/home/wq/wqpg.xaml";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PageI = "/pages/home/clo/clopg.xaml";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PageI = "/pages/home/eve/evepg.xaml";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PageI = "/pages/home/sys/syspg.xaml";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PageI = "/pages/home/page1.xaml";
        }
    }
}
