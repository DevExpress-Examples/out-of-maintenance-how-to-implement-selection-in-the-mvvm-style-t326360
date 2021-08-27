<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569978/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T326360)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MVVM%20Selection/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MVVM%20Selection/MainWindow.xaml))

* [MainWindow.xaml.cs](./CS/MVVM%20Selection/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MVVM%20Selection/MainWindow.xaml.vb))
* [Model.cs](./CS/MVVM%20Selection/Model.cs) (VB: [Model.vb](./VB/MVVM%20Selection/Model.vb))
* [ViewModel.cs](./CS/MVVM%20Selection/ViewModel.cs) (VB: [ViewModel.vb](./VB/MVVM%20Selection/ViewModel.vb))

<!-- default file list end -->

# How to: implement selection in the MVVM style


This example demonstrates how to implement chart element selection in the MVVM style.


<h3>Description</h3>

<p>To do this, enable selection using the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_SelectionModetopic">ChartControl.SelectionMode</a>&nbsp;property. Set this property to the value different from&nbsp;<strong>None</strong>.&nbsp;<br>Then, use the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_SelectedItemtopic">ChartControl.SelectedItem</a>&nbsp;property to&nbsp;set&nbsp;or get a&nbsp;single&nbsp;selected view model object, or the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_SelectedItemstopic">ChartControl.SelectedItems</a>&nbsp;property to set or get several view model objects.</p>

<br/>


