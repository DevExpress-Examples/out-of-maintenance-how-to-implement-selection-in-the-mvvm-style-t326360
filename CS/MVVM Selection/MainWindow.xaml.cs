using MVVM_Selection.ViewModel;
using System.Windows;

namespace MVVM_Selection {
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            var viewModel = DashboardViewModel.Instance;
            viewModel.PopulateData(@"..\..\Data\Top10LargestCountriesInfo.xml");
            DataContext = viewModel;
        }
    }
}
