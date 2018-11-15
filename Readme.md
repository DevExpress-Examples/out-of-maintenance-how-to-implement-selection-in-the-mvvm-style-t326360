<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/MVVM Selection/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MVVM Selection/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MVVM Selection/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MVVM Selection/MainWindow.xaml))
* [Model.cs](./CS/MVVM Selection/Model.cs) (VB: [Model.vb](./VB/MVVM Selection/Model.vb))
* [ViewModel.cs](./CS/MVVM Selection/ViewModel.cs) (VB: [ViewModel.vb](./VB/MVVM Selection/ViewModel.vb))
<!-- default file list end -->
# How to: implement selection in the MVVM style


This example demonstrates how to implement chart element selection in the MVVM style.


<h3>Description</h3>

<p>To do this, enable selection using the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_SelectionModetopic">ChartControl.SelectionMode</a>&nbsp;property. Set this property to the value different from&nbsp;<strong>None</strong>.&nbsp;<br>Then, use the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_SelectedItemtopic">ChartControl.SelectedItem</a>&nbsp;property to&nbsp;set&nbsp;or get a&nbsp;single&nbsp;selected view model object, or the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_SelectedItemstopic">ChartControl.SelectedItems</a>&nbsp;property to set or get several view model objects.</p>

<br/>


