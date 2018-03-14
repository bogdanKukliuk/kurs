using System.Runtime.Remoting.Contexts;
using System.Windows;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
            Enimals enimals = new Enimals();

            enimals.Id = "1";
            enimals.Names = "Disk";
            enimals.Descriptions = "love your hole";
            enimals.Brands = "lada";

            DataBin.Items.Add(enimals);
        }

        public class Enimals
        {
            public string Id { get; set; }
            public string Names { get; set; }
            public string Descriptions { get; set; }
            public string Brands { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            ClosesWindow closesWindow = new ClosesWindow();
            closesWindow.ShowDialog();
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Enimals enimals = new Enimals();
            enimals.Id = IdText.Text;
            enimals.Names = NameText.Text;
            enimals.Descriptions = DescriptionsText.Text;
            enimals.Brands = BrandText.Text;
            DataBin.Items.Add(enimals);
        }
    }
}
