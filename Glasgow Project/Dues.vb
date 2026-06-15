'Programmer: Kerri Stotler 2/19/2026
'Name: Dues class

Imports System.ComponentModel.Design.Serialization
Imports System.Reflection.Metadata.Ecma335

Public Class Dues
    'declare two auto-implemented properties
    Public Property BasicFee As Integer
    Public Property AdditionalFee As Integer

    'default constructor
    Public Sub New()
        BasicFee = 0
        AdditionalFee = 0
    End Sub

    'parameterized constructor
    Public Sub New(ByVal Basic As Integer, ByVal Additional As Integer)
        BasicFee = Basic
        AdditionalFee = Additional
    End Sub

    'function to return total dues
    Public Function calculateDues() As Integer
        Return BasicFee + AdditionalFee
    End Function
End Class
