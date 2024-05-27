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

namespace WpfTvs.Pages
{
    /// <summary>
    /// Interaction logic for Csik.xaml
    /// </summary>
    public partial class Csik : UserControl
    {
        public string LTitle
        {
            get { return (string)GetValue(LTitleProperty); }
            set { SetValue(LTitleProperty, value); }
        }
        public static readonly DependencyProperty LTitleProperty
            = DependencyProperty.Register("LTitle", typeof(string), typeof(Csik));
          
        public string RTitle
        {
            get { return (string)GetValue(RTitleProperty); }
            set { SetValue(RTitleProperty, value); }
        }
        public static readonly DependencyProperty RTitleProperty
            = DependencyProperty.Register("RTitle", typeof(string), typeof(Csik));

        public Csik()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
