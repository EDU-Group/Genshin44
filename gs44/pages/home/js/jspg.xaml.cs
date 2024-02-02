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

namespace gs.pages.home.js
{
    /// <summary>
    /// jspg.xaml 的交互逻辑
    /// </summary>
    public partial class jspg : Page
    {
        public jspg()
        {
            InitializeComponent();
            infoframe.Navigate(new Uri("/pages/home/js/contentpage/Page1.xaml",0));

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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            infoframe.Refresh();
        }
        public class Init : jspg
        {
            public void InitAll()
            {
                infoframe.StopLoading();
                infoframe.BeginInit();
                Uri uri = infoframe.Source;
                infoframe.Refresh();
                infoframe.Source = uri;
                infoframe.Refresh();
                infoframe.EndInit();

            }
        }
    }
}
