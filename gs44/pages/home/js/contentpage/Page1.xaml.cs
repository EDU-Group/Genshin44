using gs.pages.home.js.contentpage.infpage;
using gs44.pages.home.update;
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

namespace gs.pages.home.js.contentpage
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {

        public Page1()
        {
            InitializeComponent();
            tf.Navigate(new("/pages/home/js/contentpage/infpage/ainfo.xaml", UriKind.Relative));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tf.Refresh();

            tf.StopLoading();
            tf.BeginInit();
            Uri uri = tf.Source;
            tf.Refresh();
            tf.Source = uri;
            tf.Refresh();
            tf.EndInit();

        }

        private void Page_Initialized(object sender, EventArgs e)
        {
            tf.Refresh();
        }
        public class Init : Page1
        {
            public void InitAll()
            {
                tf.StopLoading();
                tf.BeginInit();
                Uri uri = tf.Source;
                tf.Refresh();
                tf.Source = uri;
                tf.Refresh();
                tf.EndInit();
                //MessageBox.Show("init");
            }
        }
    }
}
