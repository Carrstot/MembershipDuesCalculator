'Programmer: Kerri Stotler 2/18/2026
'Purpose: calculate and display monthly charges

'must select a fee And an add on
'basic fee for single $50, add ons are $25G, $30T, And $20R
'basic fee For family $90, add ons are $35G, $50T, $30R
'display the member's basic fee, additional charges, and monthly dues. 
'Create a class named Dues that contains two auto-implemented properties for the basic And additional charges.
'The class should also contain a default constructor, a parameterized constructor, And a method that calculates And returns the total monthly dues.
'Use the class to code the application.

Imports System.Net.Security

Public Class Form1
    'declare constants
    Const intBasicSingle As Integer = 50
    Const intBasicGolf As Integer = 25
    Const intBasicTennis As Integer = 30
    Const intBasicRaquetball As Integer = 20
    Const intBasicFamily As Integer = 90
    Const intFamilyGolf As Integer = 35
    Const intFamilyTennis As Integer = 50
    Const intFamilyRaquetball As Integer = 30

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'send message error if no membership selected
        If Not rdoSingle.Checked = True And Not rdoFamily.Checked = True Then
            MessageBox.Show("Please select a membership.")
        End If

        'determine basic fee
        Dim basicFee As Integer
        If rdoSingle.Checked Then
            basicFee = intBasicSingle
        Else
            basicFee = intBasicFamily
        End If

        'display fee in label
        lblFee.Text = basicFee.ToString("C")

        'determine additional fees
        Dim additionalFee As Integer = 0

        'determine which add ons are checked and total them
        If rdoSingle.Checked Then
            If chkGolf.Checked Then additionalFee += intBasicGolf
            If chkTennis.Checked Then additionalFee += intBasicTennis
            If chkRaquetball.Checked Then additionalFee += intBasicRaquetball
        ElseIf rdoFamily.Checked Then
            If chkGolf.Checked Then additionalFee += intFamilyGolf
            If chkTennis.Checked Then additionalFee += intFamilyTennis
            If chkRaquetball.Checked Then additionalFee += intFamilyRaquetball
        Else
            additionalFee = 0
        End If

        'display additional fee in label
        lblAdditionalFee.Text = additionalFee.ToString("C")

        'create a object from the class 
        Dim member As New Dues(basicFee, additionalFee)

        'call the method to calculate
        Dim totalDue As Integer = member.calculateDues()

        'display the results
        lblTotal.Text = totalDue.ToString("C")
    End Sub

    Private Sub Membership_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingle.CheckedChanged, rdoFamily.CheckedChanged
        'clear the checkboxes when membership changes
        chkGolf.Checked = False
        chkTennis.Checked = False
        chkRaquetball.Checked = False
        lblAdditionalFee.Text = String.Empty
        lblFee.Text = String.Empty
        lblTotal.Text = String.Empty
        btnCalculate.Focus()
    End Sub

    Private Sub AdditionalAddOns_CheckedChanged(sender As Object, e As EventArgs) Handles chkTennis.CheckedChanged, chkGolf.CheckedChanged, chkRaquetball.CheckedChanged
        'clear additional label total and total due label
        lblAdditionalFee.Text = String.Empty
        lblTotal.Text = String.Empty
        btnCalculate.Focus()
    End Sub
End Class
