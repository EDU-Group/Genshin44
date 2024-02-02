using gs.pages.home.js;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace gs.pages.loader
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent(); 

        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Next();
            Next();

        }
        async void Next()
        {
            await Task.Delay(3000);
            load.Visibility = Visibility.Visible;
            for (int i = 0; i < 360; i++)
            {
                gridbe.Radius = i/10;
                await Task.Delay(5);
            }
            await Task.Delay(2000);
            pages.main.Init init1 = new();
            init1.InitAll();
            main.Page1.init01 = true;
            pgbar.Value = 1;
            await Task.Delay(50);
            jspg.Init init2 = new();
            init2.InitAll();
            pgbar.Value = 2;
            await Task.Delay(50);
            pages.home.js.contentpage.Page1.Init init3 = new();
            init3.InitAll();
            pgbar.Value = 3;
            await Task.Delay(50);

            await Task.Delay(500);
            MainWindow.PageI = "/pages/home/Page1.xaml";

        }
    }
}
