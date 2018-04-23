Imports MVVM_Selection.Model
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Xml.Linq

Namespace MVVM_Selection.ViewModel
    Public Class DashboardViewModel
        Implements INotifyPropertyChanged


        Private Shared instance_Renamed As DashboardViewModel

        Private ReadOnly countriesData_Renamed As List(Of CountryStatisticInfo)

        Private selectedCountry_Renamed As CountryStatisticInfo

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Shared ReadOnly Property Instance() As DashboardViewModel
            Get
                If instance_Renamed Is Nothing Then
                    instance_Renamed = New DashboardViewModel()
                End If
                Return instance_Renamed
            End Get
        End Property

        Public ReadOnly Property CountriesData() As List(Of CountryStatisticInfo)
            Get
                Return countriesData_Renamed
            End Get
        End Property
        Public Property SelectedCountry() As CountryStatisticInfo
            Get
                Return selectedCountry_Renamed
            End Get
            Set(ByVal value As CountryStatisticInfo)
                If selectedCountry_Renamed IsNot value Then
                    selectedCountry_Renamed = value
                    OnPropertyChanged("SelectedCountry")
                End If
            End Set
        End Property

        Public Sub PopulateData(ByVal filepath As String)
            countriesData_Renamed.AddRange(CountriesInfoDataReader.Load(filepath))
            selectedCountry_Renamed = countriesData_Renamed(0)
        End Sub

        Private Sub New()
            countriesData_Renamed = New List(Of CountryStatisticInfo)()
        End Sub

        Private Sub OnPropertyChanged(ByVal propertyName As String)
            Dim propertyChangedEventHendler As PropertyChangedEventHandler = PropertyChangedEvent
            If propertyChangedEventHendler IsNot Nothing Then
                propertyChangedEventHendler(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    Friend Class CountriesInfoDataReader
        Private Shared Function LoadStatistic(ByVal populationDynamic As XElement) As List(Of PopulationStatisticByYear)
            Dim statistic As New List(Of PopulationStatisticByYear)()
            For Each populationDynamicItem As XElement In populationDynamic.Elements("PopulationStatisticByYear")
                Dim year As Integer = Integer.Parse(populationDynamicItem.Element("Year").Value)
                Dim population As Long = Long.Parse(populationDynamicItem.Element("Population").Value)
                Dim urbanPercent As Double = Double.Parse(populationDynamicItem.Element("UrbanPercent").Value, CultureInfo.InvariantCulture)
                Dim popDynamicItem As New PopulationStatisticByYear(year, CDbl(population) / 1000000.0, urbanPercent)
                statistic.Add(popDynamicItem)
            Next populationDynamicItem
            Return statistic
        End Function

        Public Shared Function Load(ByVal path As String) As List(Of CountryStatisticInfo)
            Dim doc As XDocument = XDocument.Load(path)
            Dim data As New List(Of CountryStatisticInfo)()
            For Each countryInfo As XElement In doc.Root.Elements("CountryInfo")
                Dim name As String = countryInfo.Element("Name").Value
                Dim areaSqKm As Double = UInteger.Parse(countryInfo.Element("AreaSqrKilometers").Value)
                Dim statistic As List(Of PopulationStatisticByYear) = LoadStatistic(countryInfo.Element("Statistic"))
                Dim countryInfoInstance As New CountryStatisticInfo(name, areaSqKm / 1000000, statistic)
                data.Add(countryInfoInstance)
            Next countryInfo
            Return data
        End Function
    End Class
End Namespace
