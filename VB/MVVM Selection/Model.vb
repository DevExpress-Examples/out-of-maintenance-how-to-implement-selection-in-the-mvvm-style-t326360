Imports System.Collections.Generic

Namespace MVVM_Selection.Model
    Public Class CountryStatisticInfo

        Private ReadOnly name_Renamed As String

        Private ReadOnly area_Renamed As Double
        Private ReadOnly statistics As List(Of PopulationStatisticByYear)

        Public ReadOnly Property Name() As String
            Get
                Return name_Renamed
            End Get
        End Property
        ' Measured in millions of square kilometers.
        Public ReadOnly Property Area() As Double
            Get
                Return area_Renamed
            End Get
        End Property
        Public ReadOnly Property PopulationDynamics() As List(Of PopulationStatisticByYear)
            Get
                Return statistics
            End Get
        End Property
        Public Sub New(ByVal name As String, ByVal area As Double, ByVal statistics As List(Of PopulationStatisticByYear))
            Me.name_Renamed = name
            Me.area_Renamed = area
            Me.statistics = statistics
        End Sub
    End Class

    Public Class PopulationStatisticByYear

        Private year_Renamed As Integer
        Private populationMillionsOfPeople As Double

        Private urbanPercent_Renamed As Double

        Public ReadOnly Property Year() As Integer
            Get
                Return year_Renamed
            End Get
        End Property
        ' Measured in Millions of people.
        Public ReadOnly Property Population() As Double
            Get
                Return populationMillionsOfPeople
            End Get
        End Property
        Public ReadOnly Property UrbanPercent() As Double
            Get
                Return urbanPercent_Renamed
            End Get
        End Property
        Public ReadOnly Property RuralPercent() As Double
            Get
                Return 100 - urbanPercent_Renamed
            End Get
        End Property

        Public Sub New(ByVal year As Integer, ByVal populationMillionsOfPeople As Double, ByVal urbanPercent As Double)
            Me.year_Renamed = year
            Me.populationMillionsOfPeople = populationMillionsOfPeople
            Me.urbanPercent_Renamed = urbanPercent
        End Sub
    End Class
End Namespace
