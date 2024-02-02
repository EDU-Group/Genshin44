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

namespace gs
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Pgc();
        }

        public static string PageI = "/pages/loader/Page1.xaml";
        private async void Pgc()
        {
            while(true)
            {
                frame.Source = new Uri(PageI, 0);
                await Task.Delay(50);
            }
        }
    }
    public class PageControl : MainWindow
    {
        public void PageIndex(string uri)
        {
            frame.Source = new Uri(uri, 0);
        }
    }
}
