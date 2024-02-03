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

namespace gs44.pages.home.update
{
    /// <summary>
    /// up.xaml 的交互逻辑
    /// </summary>
    public partial class up : Page
    {
        public up()
        {
            InitializeComponent();
            //BeginInit();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.
             PageI = "/pages/home/update/content/c01.xaml";
        }
    }
}
