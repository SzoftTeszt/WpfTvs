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
    /// Interaction logic for Elem.xaml
    /// </summary>
    public partial class Elem : UserControl
    {

        public string Title { 
            get{return (string)GetValue(TitleProperty);} 
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty
            = DependencyProperty.Register("Title", typeof(string), typeof(Elem) );
     
        public string Kind { 
            get{return (string)GetValue(KindProperty);} 
            set { SetValue(KindProperty, value); }
        }
        public static readonly DependencyProperty KindProperty
            = DependencyProperty.Register("Kind", typeof(string), typeof(Elem) );
   
        public Elem()
        {
            
            Kind = "Book";
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
