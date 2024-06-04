using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;

namespace SZGYA_WPF_HasznaltAuto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        List<Car> cars = new List<Car>();
        SearchSelection search = new SearchSelection();
        public MainWindow()
        {
            InitializeComponent();
            //initialize search
            cmbxFormFactor.DataContext = search;
            cmbxFuelType.DataContext = search;
            //initialize listings
            lstbxCarSaleList.ItemsSource = cars;

            //debug
            cars.Add(new Car() { Name = "asdasd", FormFactor = FormFactor_t.HATCHBACK });
        }

        private void btnSearchClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(EnumHelper.Description(search.SelectedFormFactor));
        }
    }

    class SearchSelection
    {
        public List<int> years;
        public SearchSelection()
        {
            years = new();
            for (int i = 1900; i < DateTime.Now.Year; i++)
            {
                years.Add(i);
            }
        }

        public FormFactor_t SelectedFormFactor { get; set; }
        public FuelType_t SelectedFuelType { get; set; }

        public int SelectedYearBoundBeggining { get; set; }
        public int SelectedYearBoundEnd { get; set; }
    }
}