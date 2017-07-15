using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MahApps.MetroProplem
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl, IDataErrorInfo
    {
        public static readonly DependencyProperty FirstNameProperty = DependencyProperty.Register("FirstName",
            typeof(string), typeof(UserControl1), new PropertyMetadata(default(string)));
        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        public string this[string columnName]
        {
            // this break point breaks twice, the last time it returns null and the validation 
            // read box doesn't disappear
            get
            {
                return string.IsNullOrWhiteSpace(FirstName) ? "ERROR" : null;
            }
        }

        public string Error { get; private set; }
    }
}
