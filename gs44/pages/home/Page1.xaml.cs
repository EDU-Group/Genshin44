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

namespace gs.pages.main
{

    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent(); 
            LabView();
        }

        private async void LabView()
        {
            lab.Visibility = Visibility.Visible;
            await Task.Delay(5000);
            lab.Visibility = Visibility.Hidden;
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
        public static Boolean init01 = false;
        private async void amain()
        {
            while(true)
            {
                switch(init01)
                {
                    case false:
                        break;
                    case true:
                        upd.BeginInit();
                        upd.Refresh();
                        init01 = false;
                        MessageBox.Show("initsw");
                        break;

                }
                await Task.Delay(50);
            }
        }

        private void Page_Initialized(object sender, EventArgs e)
        {
            //amain();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //amain();

            upd.StopLoading();
            upd.BeginInit();
            Uri uri = upd.Source;
            upd.Refresh();
            upd.Source = uri;
            upd.Refresh();
            upd.EndInit();

        }
    }
    public class Init:Page1
    {
        public void InitAll()
        {
            upd.StopLoading();
            upd.BeginInit();
            Uri uri = upd.Source;
            upd.Refresh();
            upd.Source = uri;
            upd.Refresh();
            upd.EndInit();
            //MessageBox.Show("init");
        }
    }
}
