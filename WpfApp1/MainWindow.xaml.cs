using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string texts = @"{0}怎么样呢是怎么回事呢？{0}相信大家都很熟悉，但是{0}{1}是怎么回事呢，下面就让小编带大家一起了解吧。
　　{0}怎么样呢，其实就是{2}，大家可能会很惊讶{0}{2}？但事实就是这样，小编也感到非常惊讶。
　　这就是关于{0}{1}的事情了，大家有什么想法呢，欢迎在评论区告诉小编一起讨论哦！
";
            content.Text = string.Format(texts,zt.Text,sj.Text,sf.Text);

        }
    }
}
