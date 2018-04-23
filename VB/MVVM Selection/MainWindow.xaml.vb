Imports MVVM_Selection.ViewModel
Imports System.Windows

Namespace MVVM_Selection
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Dim viewModel = DashboardViewModel.Instance
            viewModel.PopulateData("..\..\Data\Top10LargestCountriesInfo.xml")
            DataContext = viewModel
        End Sub
    End Class
End Namespace
