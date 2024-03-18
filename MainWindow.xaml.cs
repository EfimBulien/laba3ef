using System.Linq;
using System.Windows;

namespace lab1ef
{
    public partial class MainWindow : Window
    {
        private lab1Entities lab1Entities = new lab1Entities();
        public MainWindow()
        {
            InitializeComponent();
            DriversData.ItemsSource = lab1Entities.drivers.ToList();
        }
    }
}

