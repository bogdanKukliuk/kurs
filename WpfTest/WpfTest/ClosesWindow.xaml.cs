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
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для ClosesWindow.xaml
    /// </summary>
    public partial class ClosesWindow : Window
    {
        public ClosesWindow()
        {
            InitializeComponent();
            this.Closed += ClosesWindow_Closed;
        }
        void ClosesWindow_Closed(object sender, EventArgs e)
        {
            TestWindow testWindow = new TestWindow();
            testWindow.ShowDialog();
            Close();
        }
    }
}
