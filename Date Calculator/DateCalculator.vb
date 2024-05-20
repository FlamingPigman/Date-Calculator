' Created by William Chio
' Date: 13/05/2024

Imports System.Drawing.Text
Imports System.Runtime.CompilerServices

Public Class DateCalculator

    ' Constants
    Private Const DateFormat = "dd/MM/yyyy" 'Format to use for dates

    ' Days delay constants
    Private Const IGAInterval = 45
    Private Const AldiInterval = 28
    Private Const ColesInterval = 33

    Private DateTextboxMapping As New Dictionary(Of DateTimePicker, (TextBox, Integer))

    'Mapping of DatePickers to associated Textbox
    Private Sub CreateMapping()
        DateTextboxMapping.Add(IGADate, (IGATextbox, IGAInterval))
        DateTextboxMapping.Add(AldiDate, (AldiTextbox, AldiInterval))
        DateTextboxMapping.Add(ColesDate, (ColesTextbox, ColesInterval))

    End Sub



    'On startup
    Private Sub DateCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        FormatDates()
        CreateMapping()
    End Sub

    ' Format dates for all DateTimePickers
    Private Sub FormatDates()
        For Each datepicker As DateTimePicker In Me.Controls.OfType(Of DateTimePicker)
            datepicker.Format = DateTimePickerFormat.Custom
            datepicker.CustomFormat = DateFormat

            ' Reset dates on StartDate and Enddate so they are in format
            StartDate.Value = DateTime.Now
            EndDate.Value = DateTime.Now
        Next


        '
    End Sub

    ' Update the Textbox depending on date change of associated DateTimePicker, uses DateTextboxMapping to determine assciation
    Private Sub UpdateTextboxAfterDateChange(sender As Object, e As EventArgs) Handles IGADate.ValueChanged, AldiDate.ValueChanged, ColesDate.ValueChanged


        ' Using the mapping we grab the interval and Textbox associated with the DatePicker which as been called
        Dim datepicker As DateTimePicker = CType(sender, DateTimePicker)
        Dim txtbox As TextBox = DateTextboxMapping(datepicker).Item1
        Dim interval As Integer = DateTextboxMapping(datepicker).Item2

        txtbox.Text = DateAdd(DateInterval.Day, interval, datepicker.Value).ToString(DateFormat)

    End Sub

    ' Calculate days between two dates, and give absolute value
    Private Sub CalculateDateBetween(sender As Object, e As EventArgs) Handles StartDate.ValueChanged, EndDate.ValueChanged
        TextBtwn.Text = DateAndTime.DateDiff(DateInterval.Day, StartDate.Value, EndDate.Value)
    End Sub

    ' Same behaviour as UpdateTextboxAfterDateChange but deals with the Custom Days section
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles CustomDate.ValueChanged, NumericUpDown1.TextChanged

        CustomEffTextbox.Text = DateAdd(DateInterval.Day, NumericUpDown1.Value, CustomDate.Value).ToString(DateFormat)
    End Sub
End Class
